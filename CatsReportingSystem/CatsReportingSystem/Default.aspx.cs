using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL_Project;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace CatsReportingSystem
{
    public partial class _Default : Page
    {
        DAL myDal = new DAL();
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            SearchBind();
        }

        private void SearchBind()
        {
            myDal.AddParam("ID", txtClientID.Text);
            myDal.AddParam("FirstName", txtFirstName.Text);
            myDal.AddParam("LastName", txtLastName.Text);
            myDal.AddParam("DOB", txtDateofBirth.Text);
            DataSet ds = new DataSet();
            ds = myDal.ExecuteProcedure("spGetClientBySearch");
            gvClientSearch.DataSource = ds;
            gvClientSearch.DataBind();
        }


        //private void Loadtext()
        //{
        //    string userName = HttpContext.Current.User.Identity.Name;
        //}
    }
}