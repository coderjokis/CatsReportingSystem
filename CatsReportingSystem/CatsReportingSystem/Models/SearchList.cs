using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using DAL_Project;
using System.Web.UI.WebControls;

namespace CatsReportingSystem.Models
{
    public class SearchList
    {
        public CatsClient client { get; set; }
        public List<CatsClient> SResult { get; set; }
        public SearchList()
        {
            SResult = new List<CatsClient>();
        }

        public void getSearchResult(DataSet dsResult)
        {
            SResult = new List<CatsClient>();
            DataSet ds = dsResult;
            
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                SResult.Add(new CatsClient(
                    dr["ID"].ToString(),
                    dr["SIN"].ToString(),
                    dr["LastName"].ToString(),
                    dr["FirstName"].ToString(),
                    dr["DOB"].ToString()
                    ));
            }
            SResult.ToList();  
        }
    }
}