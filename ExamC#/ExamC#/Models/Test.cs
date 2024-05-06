using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamC_.Models
{
    public class Test
    {
        public string Name { get; set; }
        public List<Question> Questions { get; set; }

        internal void AddQuestion(Question question)
        {
            Questions.Add(question);
        }
    }
}
