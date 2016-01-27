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
            LoadUser(ddlUser);
        }

        private void LoadUser(ListControl l)
        {
            //DAL d = new DAL();
            //l.DataSource = d.ExecuteProcedure("spGetGenders");
            //l.DataTextField = "GenderName";
            //l.DataValueField = "GenderId";
            //l.DataBind();
            //if (l is DropDownList)
            //{
            //    l.Items.Insert(0, new ListItem("Select a Gender...", "-1"));
            //}




            DAL myDal = new DAL();
            l.DataSource = myDal.ExecuteProcedure("spGetUser");
            l.DataTextField = "UserName";
            l.DataValueField = "UserID";
            l.DataBind();
            if(l is DropDownList)
            {
                l.Items.Insert(0, new ListItem("Select Coucilor Name..."));
            }
            txtUserAccount.Text = ddlUser.SelectedValue;
        }
    }
}