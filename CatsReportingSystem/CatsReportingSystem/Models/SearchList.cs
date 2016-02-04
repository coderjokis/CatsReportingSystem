using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using DAL_Project;

namespace CatsReportingSystem.Models
{
    public class SearchList
    {
        List<SqlParameter> SearchParam;
        public CatsClient client { get; set; }
        public List<CatsClient> SResult { get; set; }
        public SearchList()
        {
            SearchParam = new List<SqlParameter>();
        }

        private void getSearchResult(CatsClient _client)
        {
            SResult = new List<CatsClient>();

        }
    }
}