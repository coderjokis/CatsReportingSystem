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
        public string Lock { get; }
        public CatsClient()
        {

        }
        public CatsClient(string clientID, string sIN, string lastName, string firstName, string dateOfBirth, string locked) :base()
        {
            this.ID = clientID;
            this.SIN = sIN;
            this.LastName = lastName;
            this.FirstName = firstName;
            this.DOB = dateOfBirth;
            this.Lock = locked;
            //ProcessMyBool(this.Lock);
        }
        //public int ProcessMyBool(int locked)
        //{
        //    for (int i = 0; i < ; i++)
        //    {

        //    }
        //    if (locked == 1)
        //    {
        //        return this.Lock;
        //    }
        //    else
        //    {
        //        return 0;//change back
        //    }
            
        //}
        public override string ToString()
        {
            var n = DateTime.Parse(DOB);
            return String.Format("{0}",n.ToString("d/MM/yyyy"));
        }
    }
}