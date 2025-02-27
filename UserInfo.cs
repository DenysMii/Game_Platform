using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Games_Platform
{
    public class UserInfo
    {
        public string Role { get; set; }
        public string ID { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime RegisterDate { get; set; }

        public UserInfo(string role, string ID, string username, string email, string password, DateTime registerDate) 
        {
            Role = role;
            this.ID = ID;
            Username = username;
            Email = email;
            Password = password;
            RegisterDate = registerDate;
        }
    }
}