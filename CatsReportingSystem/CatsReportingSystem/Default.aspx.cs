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
        DAL myDal = new DAL();
        DataSet ds = new DataSet();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            lblSearchResult.Visible = false;
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
            lvClientSearch.DataSource = ds;
            lvClientSearch.DataBind();
        }

        protected void lvClientSearch_PagePropertiesChanging(object sender, PagePropertiesChangingEventArgs e)
        {
            (lvClientSearch.FindControl("dpClientSearch") as DataPager).SetPageProperties(e.StartRowIndex, e.MaximumRows, false);
            this.SearchBind();
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
            BindContracts(e.SortExpression + " " + ListViewSortDirection.ToString());
            if (ListViewSortDirection == SortDirection.Ascending)
                ListViewSortDirection = SortDirection.Ascending;
            else
                ListViewSortDirection = SortDirection.Descending;
        }

        private void BindContracts(string sortExpression)
        {
            sortExpression = sortExpression.Replace("Ascending", "ASC");
            sortExpression = sortExpression.Replace("Decending", "DESC");
            
            
            LoadDLClientSearch();
        }

        //private void Loadtext()
        //{
        //    string userName = HttpContext.Current.User.Identity.Name;
        //}
    }
}