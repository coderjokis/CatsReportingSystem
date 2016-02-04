using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DAL_Project;
using System.Data;

namespace CatsReportingSystem.Models
{
    public class CatsClient
    {
        public string ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SIN { get; set; }
        public string DOB { get; set; }
        public bool Lock { get; set; }
        public CatsClient()
        {

        }
        public CatsClient(string clientID, string firstName, string lastName, string sIN, string dateOfBirth, bool locked) :base()
        {
            this.ID = clientID;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.SIN = sIN;
            this.DOB = dateOfBirth;
            this.Lock=locked;
        }
       
    }
}