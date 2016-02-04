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
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        SearchList sl = new SearchList();
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
            lblSearchResult.Visible = false;
            ParamCheck();
            SearchBind();
        }

        private void ParamCheck()
        {
            if (txtClientID.Text != "")
            {
                myDal.AddParam("ID", txtClientID.Text);
                //sl.AddSearchParam("ID", txtClientID.Text);
            }
            if (txtSIN.Text != "")
            {
                myDal.AddParam("SIN", txtSIN.Text);
                //sl.AddSearchParam("SIN", txtSIN.Text);
            }
            if (txtFirstName.Text != "")
            {
                myDal.AddParam("FirstName", txtFirstName.Text);
                //sl.AddSearchParam("FirstName", txtFirstName.Text);
            }
            if (txtLastName.Text != "")
            {
                myDal.AddParam("LastName", txtLastName.Text);
                //sl.AddSearchParam("LastName", txtLastName.Text);
            }
            if (txtDateofBirth.Text != "")
            {
                myDal.AddParam("DOB", txtDateofBirth.Text);
                //sl.AddSearchParam("DOB", txtDateofBirth.Text);
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
            var myData = ds.Tables[0].AsEnumerable().Select(r => new CatsClient { ID = r.Field<int>("ID").ToString(),
                SIN = r.Field<string>("SIN"),
                FirstName = r.Field<string>("FirstName"),
                LastName = r.Field<string>("LastName"),
                DOB = r.Field<DateTime>("DOB").ToString("dd/MM/yyyy"),
                Lock = r.Field<>("Lock").ToString(),
            });
            sl.SResult = myData.ToList();
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