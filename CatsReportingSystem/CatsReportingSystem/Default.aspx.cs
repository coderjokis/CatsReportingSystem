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
            lblSearchResult.Visible = false;
            gvClientSearch.DataSource = "";

            SearchBind();
        }

        private void ParamCheck()
        {
            if (txtClientID.Text != "")
            {
                myDal.AddParam("ID", txtClientID.Text);
            }
            if (txtSIN.Text != "")
            {
                myDal.AddParam("SIN", txtSIN.Text);
            }
            if (txtFirstName.Text != "")
            {
                myDal.AddParam("FirstName", txtFirstName.Text);
            }
            if (txtLastName.Text != "")
            {
                myDal.AddParam("LastName", txtLastName.Text);
            }
            if (txtDateofBirth.Text != "")
            {
                myDal.AddParam("DOB", txtDateofBirth.Text);
            }

        }

        private void SearchBind()
        {
            ParamCheck();
            DataSet ds = new DataSet();
            ds = myDal.ExecuteProcedure("spGetClientBySearch");

            if (ds.Tables[0].Rows.Count > 1)
            {
                gvClientSearch.DataSource = ds;
                gvClientSearch.DataBind();
            }
            else
            {
                lblSearchResult.Visible = true;
                lblSearchResult.Text = "No result found!";
            }
        }

        //private void Loadtext()
        //{
        //    string userName = HttpContext.Current.User.Identity.Name;
        //}
    }
}