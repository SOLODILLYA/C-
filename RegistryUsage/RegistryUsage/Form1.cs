using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace RegistryUsage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            setValues(this);
        }

        private void setValues(Form1 form)
        {
            string keyPath = @"SOFTWARE\MyApp";
            string valueName = "BackgroundColor";

            if (form != null)
            {
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey(keyPath))
                {
                    if (key != null)
                    {
                        object value = key.GetValue(valueName);
                        if (value != null)
                        {
                            try
                            {
                                Color backgroundColor = ColorTranslator.FromHtml((string)value);
                                form.BackColor = backgroundColor;
                            }
                            catch (Exception ex)
                            {
                                form.BackColor = Color.LightGray;
                            }
                        }
                        else
                        {
                            form.BackColor = Color.LightGray;
                        }
                        valueName = "FontSize";
                        value = key.GetValue(valueName);
                        if (value != null)
                        {
                            try
                            {
                                label1.Font = new Font("Arial", (int)value);
                                label2.Font = new Font("Arial", (int)value);
                                label3.Font = new Font("Arial", (int)value);
                            }
                            catch (Exception ex)
                            {
                                label1.Font = new Font("Arial", 8);
                                label2.Font = new Font("Arial", 8);
                                label3.Font = new Font("Arial", 8);
                            }
                        }
                        else
                        {
                            label1.Font = new Font("Arial", 8);
                            label2.Font = new Font("Arial", 8);
                            label3.Font = new Font("Arial", 8);
                        }
                        valueName = "WindowSize";
                        value = key.GetValue(valueName);
                        if (value != null)
                        {
                            string[] parts = ((string)value).Split('x');

                            if (parts.Length == 2)
                            {
                                if (int.TryParse(parts[0], out int width) && int.TryParse(parts[1], out int height))
                                {
                                    this.Size = new Size(width, height);
                                }
                                else
                                {
                                    this.Size = new Size(200, 250);
                                }
                            }
                            else
                            {
                                this.Size = new Size(200, 250);
                            }
                        }
                        else
                        {
                            this.Size = new Size(200, 250);
                        }
                    }
                    else
                    {
                        form.BackColor = Color.LightGray;
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string keyPath = @"SOFTWARE\MyApp";
            string valueName = "BackgroundColor";

            using (RegistryKey key = Registry.CurrentUser.CreateSubKey(keyPath))
            {
                if (!string.IsNullOrWhiteSpace(ColorTextBox.Text))
                {
                    key.SetValue(valueName, ColorTextBox.Text);
                }

                ColorTextBox.Clear();

                valueName = "FontSize";
                if (!string.IsNullOrWhiteSpace(FontTextBox.Text))
                {
                    try
                    {
                        int size = int.Parse(FontTextBox.Text);
                        key.SetValue(valueName, size);
                    }catch(Exception ex)
                    {
                        MessageBox.Show("Invalid value for font size");
                    }
                }

                FontTextBox.Clear();

                valueName = "WindowSize";
                if (!string.IsNullOrWhiteSpace(WindowSizeTextBox.Text))
                {
                    key.SetValue(valueName, WindowSizeTextBox.Text);
                }

                WindowSizeTextBox.Clear();
            }



            setValues(this);
        }
    }
}
