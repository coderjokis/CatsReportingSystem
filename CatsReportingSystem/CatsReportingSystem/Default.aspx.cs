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
        protected void Page_Load(object sender, EventArgs e)
        {
            Loadtext();
        }

        private void Loadtext()
        {
            string userName = HttpContext.Current.User.Identity.Name;
            txtUsername.Text = HttpUtility.UrlDecode(Request.QueryString[userName]);
        }
    }
}