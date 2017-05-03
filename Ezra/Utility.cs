using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace Ezra
{
    class Utility
    {
        public static string[] GetAvailableYears()
        {
            List<string> availYears = new List<string>();
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.EzraConnectionString))
            {
                string sql = "Select DISTINCT Year(ChkDate) as ChkYear From CKCUChecking Order By ChkYear Desc";
                conn.Open();
                using (SqlDataAdapter a = new SqlDataAdapter(sql, conn))
                {
                    DataTable dt = new DataTable("Years");
                    a.Fill(dt);
                    var chkYears = dt.AsEnumerable();
                    foreach (DataRow row in chkYears)
                    {
                        availYears.Add(row[0].ToString());
                    }
                }
                return availYears.ToArray<string>();
            }
        }
    }
}
