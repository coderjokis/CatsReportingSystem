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
using System.Web.UI.HtmlControls;

namespace CatsReportingSystem
{
    public partial class _Default : Page
    {
        //    string userName = HttpContext.Current.User.Identity.Name;
        DAL myDal = new DAL();
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        string sortExpression;
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        private void BindContacts(string sortExpression)
        {
            sortExpression = sortExpression.Replace("Ascending", "ASC");
            sortExpression = sortExpression.Replace("Descending", "DESC");
            ParamCheck();
            SearchBind();
            
            LoadDLClientSearch();
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            lblSearchResult.Visible = false;
            ParamCheck();
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
            ds = myDal.ExecuteProcedure("spGetClientBySearch");

            if (ds.Tables[0].Rows.Count > 1)
            {
                LoadDLClientSearch();
            }
            else
            {
                lblSearchResult.Visible = true;
                lblSearchResult.Text = "No result found!";
            }
        }

        private void LoadDLClientSearch()
        {
            dt.DefaultView.Sort = sortExpression;
            dt = ds.Tables[0];
            lvClientSearch.DataSource = dt;
            lvClientSearch.DataBind();
        }

        protected void lvClientSearch_PagePropertiesChanging(object sender, PagePropertiesChangingEventArgs e)
        {
            (lvClientSearch.FindControl("dpClientSearch") as DataPager).SetPageProperties(e.StartRowIndex, e.MaximumRows, false);
            ParamCheck();
            SearchBind();
            LoadDLClientSearch();

        }

    protected SortDirection ListViewSortDirection
        {
            get
            {
                if (ViewState["sortDirection"] == null)
                    ViewState["sortDirection"] = SortDirection.Ascending;
                return (SortDirection)ViewState["sortDirection"];
            }
            set { ViewState["sortDirection"] = value; }
        }

        protected void lvClientSearch_Sorting(object sender, ListViewSortEventArgs e)
        {
            BindContacts(e.SortExpression + " " + ListViewSortDirection.ToString());

            //string imgUrl; i do not know if you have use
            if (ListViewSortDirection == SortDirection.Ascending)
                ListViewSortDirection = SortDirection.Descending;
            else
                ListViewSortDirection = SortDirection.Ascending;

        }

    }
}