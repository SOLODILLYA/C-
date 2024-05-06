using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksCatalog.Models
{
    internal class SubjectsCatalog
    {
        public string Name { get; set; }
        public List<Subject> Subjects { get; set; }

        public SubjectsCatalog()
        {
            Subjects = new List<Subject>();
        }
    }
}
