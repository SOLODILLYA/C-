using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamC_.Models
{
    public class TestsData
    {
        public List<Test> Tests { get; set; }

        public TestsData()
        {
            Tests = new List<Test>();
        }

        internal void Add(Test test)
        {
            Tests.Add(test);
        }
    }
}
