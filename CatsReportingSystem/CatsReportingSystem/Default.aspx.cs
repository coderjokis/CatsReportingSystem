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
using CatsReportingSystem.Models;

namespace CatsReportingSystem
{
    public partial class _Default : Page
    {
        //    string userName = HttpContext.Current.User.Identity.Name;
        DAL myDal = new DAL();
        DataSet dsResult; /*= new DataSet();*/
        //DataTable dt = new DataTable();
        SearchList sl = new SearchList();
        string _searchParam;
        string _myDalParam;
        //CatsClient client;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Session["Column"] = "Column";
            }
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            lvClientSearch.Items.Clear();
            lblSearchResult.Visible = false;
            ParamCheck();
            SearchBind();
            TestBindingToGV();
        }

        private void TestBindingToGV()
        {
            gvDatatest.DataSource = sl.SResult;
            gvDatatest.DataBind();
        }

        private string ParamCheck()
        {
            if (txtClientID.Text != "")
            {
                //myDal.AddParam("ID", txtClientID.Text);
                _searchParam = txtClientID.Text;
                _myDalParam = "ID";
            }
            if (txtSIN.Text != "")
            {
                // myDal.AddParam("SIN", txtSIN.Text);
                _searchParam = txtSIN.Text;
                _myDalParam = "SIN";
            }
            if (txtFirstName.Text != "")
            {
                // myDal.AddParam("FirstName", txtFirstName.Text);
                _searchParam = txtFirstName.Text;
                _myDalParam = "FirstName";
            }
            if (txtLastName.Text != "")
            {
                // myDal.AddParam("LastName", txtLastName.Text);
                _searchParam = txtLastName.Text;
                _myDalParam = "LastName";
            }
            if (txtDateofBirth.Text != "")
            {
                // myDal.AddParam("DOB", txtDateofBirth.Text);
                _searchParam = txtDateofBirth.Text;
                _myDalParam = "DOB";
            }

            return _searchParam;
        }

        private void SearchBind()
        {
            myDal.AddParam(_myDalParam, _searchParam);
            dsResult = myDal.ExecuteProcedure("spGetClientBySearch");

            if (dsResult.Tables[0].Rows.Count > 1)
            {
                LoadDLClientSearch();
                lblSearchResult.Visible = true;
                lblSearchResult.Text = dsResult.Tables[0].Rows.Count + " Results Found.";
            }
            else
            {
                lblSearchResult.Visible = true;
                lblSearchResult.Text = "No result found!";
            }
        }

        private void LoadDLClientSearch()
        {
            sl.getSearchResult(dsResult);
            BindData();

        }
        private void BindData()
        {
            lvClientSearch.DataSource = sl.SResult;
            lvClientSearch.DataBind();
        }

        protected void lvClientSearch_PagePropertiesChanging(object sender, PagePropertiesChangingEventArgs e)
        {
            
            (lvClientSearch.FindControl("dpClientSearch") as DataPager).SetPageProperties(e.StartRowIndex, e.MaximumRows, false);
            //BindData(); -- this event cant run w/out full get.
            this.ExecLoadMethods();
            base.OnPreRender(e);

        }

        protected void lvClientSearch_Sorting(object sender, ListViewSortEventArgs e)
        {
            Session["Column"] = e.SortExpression;
            myDal.AddParam("Column", Session["Column"].ToString());
            ExecLoadMethods();
        }

        private void ExecLoadMethods()
        {
            ParamCheck();
            SearchBind();
            BindData();
        }

    }
}