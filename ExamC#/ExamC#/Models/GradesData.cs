using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamC_.Models
{
    public class GradesData
    {
        public List<Grade> Grades { get; set; }

        internal void Add(Grade grade)
        {
            Grades.Add(grade);
        }
    }
}
