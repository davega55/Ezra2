using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ezra
{
    class CodeSnippets
    {
        private void Snip1()
        {
            //using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.EzraConnectionString))
            //{
            //    conn.Open();
            //    string sql = "Select cats.CatID, cats.CatName, cats.CatGrpID, grp.grpName, cats.CatType, typ.TypeDesc, " +
            //        "cats.CatPrintOrd, grp.grpPrintOrd, grp.grpBudOrder from Categories cats " +
            //        "Join Groups grp on grp.grpID = cats.CatGrpID " +
            //        "Join dbo.Type typ on typ.TypeID = cats.CatType";
            //    using (SqlCommand cmd = new SqlCommand(sql, conn))
            //    using (SqlDataReader reader = cmd.ExecuteReader())
            //    {
            //        while (reader.Read())
            //        {
            //            string catName = reader.GetString(1);
            //            string catGroup = reader.GetString(3);
            //            decimal expense = 0;
            //            decimal deposit = 0;
            //            string catType = reader.GetString(5);
            //            short catPrint = 0;
            //            if (!reader.IsDBNull(6))
            //                catPrint = reader.GetInt16(6);
            //            short groupPrint = 0;
            //            if (!reader.IsDBNull(7))
            //                groupPrint = reader.GetInt16(7);
            //            short budOrder = 0;
            //            if (!reader.IsDBNull(8))
            //                budOrder = reader.GetInt16(8);

            //            dsEzra.tmpCatAmounts.AddtmpCatAmountsRow(catName, catGroup, expense, deposit, catType, catPrint, groupPrint, budOrder);
            //            dsEzra.tmpCatAmounts.AcceptChanges();
            //        }
            //    }
            //    string sqlOffering = "select dbo.GetSummedIncome ('2016-06-01', '2016-06-30', 10)";

            //    using (SqlCommand cmdOffering = new SqlCommand(sqlOffering, conn))
            //    {
            //        result = Convert.ToDecimal(cmdOffering.ExecuteScalar());
            //    }
            //}
        }
    }
}
