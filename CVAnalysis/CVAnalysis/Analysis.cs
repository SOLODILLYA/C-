using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CVAnalysis
{
    public partial class Analysis : Form
    {
        Form1 form;

        List<Person> allPersons = new List<Person>();
        public Analysis(Form1 form1)
        {
            InitializeComponent();
            form = form1;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private Person analyze(string path)
        {
            try
            {
                string xmlFilePath = path;
                string xmlString = File.ReadAllText(xmlFilePath);

                XDocument xmlDoc = XDocument.Parse(xmlString);

                XElement personElement = xmlDoc.Root.Element("person");
                Person person = new Person
                {
                    Name = (string)personElement.Element("name"),
                    YearsOfWork = (int)personElement.Element("yearsOfWork"),
                    City = (string)personElement.Element("city"),
                    Salary = (float)personElement.Element("salary")
                };
                return person;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return null;
            }

        }

        private void Analysis_Load(object sender, EventArgs e)
        {
            List<string> listItemsCopy = new List<string>(form.ListItems);

            Task[] tasks = new Task[listItemsCopy.Count];
            for (int i = 0; i < listItemsCopy.Count; i++)
            {
                string path = listItemsCopy[i];
                tasks[i] = Task.Run(() => analyze(path))
                    .ContinueWith(task =>
                    {
                        if (task.Status == TaskStatus.RanToCompletion)
                        {
                            Person person = task.Result;
                            if (person != null)
                            {
                                lock (allPersons)
                                {
                                    allPersons.Add(person);
                                }
                            }
                        }
                    });
            }

            Task.WaitAll(tasks);
            Fill();
        }

        private void Fill()
        {
            Person mostYearsOfWork = allPersons.OrderByDescending(p => p.YearsOfWork).FirstOrDefault();
            MostWork.Text = mostYearsOfWork.Name;
            Person leastYearsOfWork = allPersons.OrderBy(p => p.YearsOfWork).FirstOrDefault();
            LeastWork.Text = leastYearsOfWork.Name;
            Person mostExpensive = allPersons.OrderByDescending(p => p.Salary).FirstOrDefault();
            MostExpensive.Text = mostYearsOfWork.Name;
            Person leastExpensive = allPersons.OrderBy(p => p.Salary).FirstOrDefault();
            LeastExpensive.Text = leastYearsOfWork.Name;

            var groupedByCity = allPersons.GroupBy(p => p.City);

            foreach (var group in groupedByCity)
            {
                string cityInfo = $"{group.Key}: {string.Join(", ", group.Select(p => p.Name))}";

                Cities.Items.Add(cityInfo);
            }
        }
    }
}
