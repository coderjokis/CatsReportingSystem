using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace CatsReportingSystem.Models
{
    public class User
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public bool IsLoggedIn { get; set; }
        public bool IsActive { get; set; }

        public User()
        {
        }
        public User(int userID, string userName)
        {
            this.UserID = userID;
            this.UserName = userName;
        }
    }
}