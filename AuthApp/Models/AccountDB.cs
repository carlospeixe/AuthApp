using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AuthApp.Models;

namespace AuthApp.Models
{
    public class AccountDB
    {
        private List<User> usersList = new List<User>();

        public AccountDB()
        {
            usersList.Add(new User { Id = 1, Username = "noAccess", Password = "123", Roles = new string[] { }, LoggedIn = false });
            usersList.Add(new User { Id = 2, Username = "user", Password = "123", Roles = new string[] {"user" }, LoggedIn = false });
            usersList.Add(new User { Id = 3, Username = "admin", Password = "123", Roles = new string[] {"admin", "user" }, LoggedIn = false });
        }

        public User find(string username)
        {
            return usersList.Where(u => u.Username.Equals(username)).FirstOrDefault();
        } 

        public User login(string username, string password)
        {
            return usersList.Where(u => u.Username.Equals(username) && u.Password.Equals(password)).FirstOrDefault();
        }
    }
}