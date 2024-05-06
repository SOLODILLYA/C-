using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserEnum
{
    internal class Users
    {
        List<User> _users;
        public Users() { 
            _users = new List<User>();
        }

        public void Demo()
        {
            _users.Add(new User()
            {
                Name = "John",
                Surname = "Doe",
                Login = "@johnDoe",
                Password = "Password",
                Birthday = "1990-12-1",
                RegDate = "2024-01-03",
                Role = "admin",
                MartialStatus = MartialStatus.Dating,
                SocialStatus = SocialStatus.Student,
                GenderStatus = GenderStatus.Male,
            });
            _users.Add(new User()
            {
                Name = "Anna",
                Surname = "Dark",
                Login = "@annaDark",
                Password = "Danna",
                Birthday = "1970-12-2",
                RegDate = "2024-02-16",
                Role = "C# junior",
                MartialStatus = MartialStatus.Married,
                SocialStatus = SocialStatus.Unemployed,
                GenderStatus = GenderStatus.Female,
            });
            _users.Add(new User()
            {
                Name = "Example",
                Surname = "Test",
                Login = "@exmp",
                Password = "test",
                Birthday = "1975-12-3",
                RegDate = "2024-03-14",
                Role = "C++ junior",
                MartialStatus = MartialStatus.Single,
                SocialStatus = SocialStatus.Employed,
                GenderStatus = GenderStatus.Other,
            });

            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("| Name     | Surname | Login      | Password     | Birthday   | RegDate    | Role         | Martial Status | Social Status  | Gender |");
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------");

            foreach (var user in _users)
            {
                Console.WriteLine($"| {user.Name,-8} | {user.Surname,-7} | {user.Login,-10} | {user.Password,-12} | {user.Birthday,-10} | {user.RegDate,-10} | {user.Role,-12} | {user.MartialStatus,-14} | {user.SocialStatus,-14} | {user.GenderStatus,-6} |");
            }

            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------");

        }
    }
}
