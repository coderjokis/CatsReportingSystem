using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CatsReportingSystem.Models
{
    public class Admin : User
    {
        public int AdminID { get; set; }
        public string AdminName { get; set; }
    }
}