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
            LoadUsers();
        }

        private void LoadUsers()
        {
            DAL myDal = new DAL();
            gvUsers.DataSource = myDal.ExecuteProcedure("spGetUser");
            gvUsers.DataBind();
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            DAL myDal = new DAL();
            myDal.AddParam("UserName", txtUsername.Text);
            string sProc;
            
            sProc = "spUpdateUser";
            myDal.AddParam("UserID", txtUserID.Text);
            myDal.ExecuteProcedure(sProc);

            LoadUsers();
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            txtUserID.Text = "";
            txtUsername.Text = "";
        }

        protected void gvUsers_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int rowID = Convert.ToInt32(e.CommandArgument);
            gvUsers.SelectedIndex = rowID;
            string UserID = gvUsers.SelectedDataKey.Value.ToString();
            string cmd = e.CommandName;
            
            switch (cmd)
            {
                case "Upd":
                    UpdateUser(UserID,
                               gvUsers.SelectedRow.Cells[2].Text);
                    break;
            }
        }

        private void UpdateUser(string UserID, string UserName)
        {
            txtUserID.Text = UserID;
            txtUsername.Text = UserName;
        }
    }
}