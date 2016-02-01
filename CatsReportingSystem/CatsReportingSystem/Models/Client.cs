using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DAL_Project;
using System.Data;

namespace CatsReportingSystem.Models
{
    public class Client
    {
        public string ClientID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SIN { get; set; }
        public string DateOfBirth { get; set; }
        public Client()
        {

        }
        public Client(string clientID, string firstName, string lastName, string sIN, string dateOfBirth)
        {
            this.ClientID = clientID;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.SIN = sIN;
            this.DateOfBirth = dateOfBirth;
        }
        public void ClientSearch()
        {
            
        }
    }
}