using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamC_.Models
{
    internal class UsersData
    {
        public string Name { get; set; }
        public List<User> Users { get; set; }

        public UsersData()
        {
            Users = new List<User>();
        }
    }
}
