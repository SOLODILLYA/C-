using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserEnum
{
    enum MartialStatus
    {
        Single,
        Dating,
        Married
    }

    enum SocialStatus
    {
        Student,
        Employed,
        Unemployed
    }

    enum GenderStatus
    {
        Male,
        Female,
        Other
    }

    internal class User
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Birthday { get; set; }
        public string RegDate { get; set; }
        public string Role { get; set; }
       public  MartialStatus MartialStatus { get; set; }
        public SocialStatus SocialStatus { get; set; }
        public GenderStatus GenderStatus { get; set; }
    }
}
