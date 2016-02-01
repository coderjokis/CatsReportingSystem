using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CatsReportingSystem.Models
{
    public class Client
    {
        public int ClientID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int SIN { get; set; }
        public DateTime DateOfBirth { get; set; }
        public bool Status { get; set; }

        public Client(int clientID, string firstName, string lastName, int sIN, DateTime dateOfBirth, bool isActive)
        {
            this.ClientID = clientID;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.SIN = sIN;
            this.DateOfBirth = dateOfBirth;
            this.Status = isActive;
        }
    }
}