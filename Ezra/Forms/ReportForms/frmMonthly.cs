using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;
using Microsoft.Reporting.WinForms;

namespace Ezra
{
    public partial class frmMonthly : Form
    {
        private string strYear = "";
        private string strMonth = "";

        public frmMonthly(string year, string month)
        {
            InitializeComponent();
            strYear = year;
            strMonth = month;
        }

        private void frmMonthly_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.SetParameters(FillReportParms());
            reportViewer1.RefreshReport();
        }

        private ReportParameter[] FillReportParms()
        {
            int month = DateTime.ParseExact(strMonth, "MMMM", CultureInfo.CurrentCulture).Month;
            int year;
            int.TryParse(strYear, out year);
            DateTime dtBeginDate = new DateTime(year, month, 1);
            DateTime dtEndDate = dtBeginDate.AddMonths(1).AddDays(-1);
            string strBegDate = dtBeginDate.ToString("yyyy-MM-dd");
            string strEndDate = dtEndDate.ToString("yyyy-MM-dd");
            taMonthlyNumbers.FillGetMonthlyNumbers(dsEzra.MonthlyNumbers, dtBeginDate, dtEndDate);

            decimal offering = dsEzra.MonthlyNumbers.First(a => a.CatNum == 10).Amount;
            decimal dividend = dsEzra.MonthlyNumbers.First(a => a.CatNum == 31).Amount;
            decimal maintenance = dsEzra.MonthlyNumbers.First(a => a.CatNum == 3).Amount;
            decimal cleaning = dsEzra.MonthlyNumbers.First(a => a.CatNum == 6).Amount;
            decimal insurance = dsEzra.MonthlyNumbers.First(a => a.CatNum == 2).Amount;
            decimal education = dsEzra.MonthlyNumbers.First(a => a.CatNum == 11).Amount;
            decimal missions = dsEzra.MonthlyNumbers.First(a => a.CatNum == 17).Amount;
            decimal compensation = dsEzra.MonthlyNumbers.First(a => a.CatNum == 7).Amount;
            decimal withholding = dsEzra.MonthlyNumbers.First(a => a.CatNum == 29).Amount;
            decimal businessSupplies = dsEzra.MonthlyNumbers.First(a => a.CatNum == 20).Amount;
            decimal buildingSupplies = dsEzra.MonthlyNumbers.First(a => a.CatNum == 4).Amount;
            decimal pastorsExpense = dsEzra.MonthlyNumbers.First(a => a.CatNum == 21).Amount;
            decimal gas = dsEzra.MonthlyNumbers.First(a => a.CatNum == 13).Amount;
            decimal electric = dsEzra.MonthlyNumbers.First(a => a.CatNum == 12).Amount;
            decimal telephone = dsEzra.MonthlyNumbers.First(a => a.CatNum == 26).Amount;
            decimal pulpitSupply = dsEzra.MonthlyNumbers.First(a => a.CatNum == 23).Amount;
            decimal miscellaneous = dsEzra.MonthlyNumbers.First(a => a.CatNum == 16).Amount;
            //// Get withholding amounts from FundTransactions
            taWithholding.FillWithholding(dsEzra.Withholding, dtBeginDate, dtEndDate, 9);
            decimal stateWH = dsEzra.Withholding.First().DepAmount;
            taWithholding.FillWithholding(dsEzra.Withholding, dtBeginDate, dtEndDate, 10);
            decimal fedWH = dsEzra.Withholding.First().DepAmount;
            decimal totWH = stateWH + fedWH;
            string dateHeading = "For " + dtBeginDate.ToString("MM/dd/yy") + " To " + dtEndDate.ToString("MM/dd/yy");
            decimal budget = Math.Round((decimal)taQueries.GetBudget("2016") / 12, 2);
            decimal budOverUnder = Math.Round((offering + dividend) - budget, 2);
            string strBudOverUnder = string.Empty;
            if(budOverUnder < 0)
            {
                strBudOverUnder = "($" + Math.Abs(budOverUnder).ToString() + ") Under Budget";
            }
            else
            {
                strBudOverUnder = "$" + budOverUnder.ToString() + " Over Budget";
            }

            ReportParameter rpOffering = new ReportParameter("Offering", offering.ToString());
            ReportParameter rpDividend = new ReportParameter("Dividend", dividend.ToString());
            ReportParameter rpMaintenance = new ReportParameter("Maintenance", maintenance.ToString());
            ReportParameter rpCleaning = new ReportParameter("Cleaning", cleaning.ToString());
            ReportParameter rpInsurance = new ReportParameter("Insurance", insurance.ToString());
            ReportParameter rpMissions = new ReportParameter("Missions", missions.ToString());
            ReportParameter rpCompensation = new ReportParameter("Compensation", compensation.ToString());
            ////ReportParameter rpWithholding = new ReportParameter("Withholding", withholding.ToString());
            ReportParameter rpWithholding = new ReportParameter("Withholding", totWH.ToString());
            ReportParameter rpBusinessSupplies = new ReportParameter("BusinessSupplies", businessSupplies.ToString());
            ReportParameter rpBuildingSupplies = new ReportParameter("BuildingSupplies", buildingSupplies.ToString());
            ReportParameter rpPastorsExpense = new ReportParameter("PastorsExpense", pastorsExpense.ToString());
            ReportParameter rpGas = new ReportParameter("Gas", gas.ToString());
            ReportParameter rpElectric = new ReportParameter("Electric", electric.ToString());
            ReportParameter rpTelephone = new ReportParameter("Telephone", telephone.ToString());
            ReportParameter rpPulpitSupply = new ReportParameter("PulpitSupply", pulpitSupply.ToString());
            ReportParameter rpMiscellaneous = new ReportParameter("Miscellaneous", miscellaneous.ToString());
            ReportParameter rpDateHeading = new ReportParameter("DateHeading", dateHeading);
            ReportParameter rpBudget = new ReportParameter("Budget", budget.ToString());
            ReportParameter rpBudOverUnder = new ReportParameter("BudgetOverUnder", strBudOverUnder);
            ReportParameter[] parms = new ReportParameter[] { rpOffering, rpDividend, rpMaintenance, rpCleaning, rpInsurance, rpMissions, rpCompensation,
                rpWithholding, rpBusinessSupplies, rpBuildingSupplies, rpPastorsExpense, rpGas, rpElectric, rpTelephone, rpPulpitSupply, rpMiscellaneous,
                rpDateHeading, rpBudget, rpBudOverUnder};
            return parms;
        }
    }
}
