using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamC_.Models
{
    public class Grade
    {
        public string Email { get; set; }
        public float Score { get; set; }
        public string Exam { get; set; }

        public override string ToString()
        {
            return $"{Email} {Exam} {Score}";
        }
    }
}
