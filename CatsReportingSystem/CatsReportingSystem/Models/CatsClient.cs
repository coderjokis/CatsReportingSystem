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
        public int Lock { get; }
        public CatsClient()
        {

        }
        public CatsClient(string clientID, string firstName, string lastName, string sIN, string dateOfBirth) :base()
        {
            this.ID = clientID;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.SIN = sIN;
            this.DOB = dateOfBirth;
            ProcessMyBool(this.Lock);
        }
        public int ProcessMyBool(int locked)
        {
            if (locked == 1)
            {
                return this.Lock;
            }
            else
            {
                return 0;//change back
            }
            
        }
        public override string ToString()
        {
            var n = DateTime.Parse(DOB);
            return String.Format("{0}",n.ToString("d MMMM, yyyy"));
        }
    }
}