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
        string conn=ConfigurationManager.ConnectionStrings["ConnToAlan"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadUser();
        }

        private void LoadUser()
        {
            DAL myDal = new DAL(conn);
            DataSet ds = myDal.ExecuteProcedure("spGetUser");
            SqlDataAdapter da = new SqlDataAdapter();
            ddlUser.DataSource = ds.Tables[0].Rows[0]["UserName"].ToString();
            ddlUser.DataBind();

            txtUserAccount.Text = ddlUser.SelectedValue;
        }
    }
}