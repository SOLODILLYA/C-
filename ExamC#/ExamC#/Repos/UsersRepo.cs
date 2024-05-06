using ExamC_.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ExamC_.Repos
{
    internal class UsersRepo
    {

        private UsersData _usersData;
        private readonly string _filePath;
        private User currentUser = new User()
        {
            Role = "guest",
            Email = ""
        };

        public void setCurrentUser(User user)
        {
            currentUser = user;
        }

        public User getCurrentUser()
        {
            return currentUser;
        }
        public void LoadData()
        {
            string data = File.ReadAllText(_filePath);
            _usersData = JsonSerializer.Deserialize<UsersData>(data);
        }

        public void SaveData()
        {
            string data = JsonSerializer.Serialize(_usersData);
            File.WriteAllText(_filePath, data);
        }

        public void AddUser(User user)
        {
            _usersData.Users.Add(user);
            SaveData();
        }

        internal List<User> getUsers()
        {
            return _usersData.Users;
        }

        public UsersRepo()
        {
            _usersData = new UsersData();
            _filePath = @"..\..\Data\Users.json";
            LoadData();
        }
    }
}
