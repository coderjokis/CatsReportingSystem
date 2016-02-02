using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL_Project;
using System.Configuration;

namespace CatsReportingSystem.Admin
{
    public partial class Admin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            DAL myDal = new DAL();
            myDal.AddParam("SIN", txtSIN.Text);
            myDal.AddParam("FirstName", txtFirstName.Text);
            myDal.AddParam("LastName", txtLastName.Text);
            myDal.AddParam("DateofBirth", txtDateofBirth.Text);
            string sProc;

            sProc = "spUpdateClient";
            myDal.AddParam("ClientID", txtClientID.Text);
            myDal.ExecuteProcedure(sProc);
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            txtClientID.Text = "";
            txtSIN.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtDateofBirth.Text = "";
        }
    }
}