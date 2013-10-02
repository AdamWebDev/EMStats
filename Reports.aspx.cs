using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Globalization;

namespace EMStats
{
    public partial class Reports : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SecurePage();

            if (!IsPostBack)
            {
                PopulateMonths();
                PopulateYears();
            }
        }

        private void PopulateMonths()
        {
            var months = CultureInfo.CurrentCulture.DateTimeFormat.MonthNames;
            for (int i = 0; i < months.Length - 1; i++)
            {
                ddStartMonth.Items.Add(new ListItem(months[i], (i + 1).ToString()));
                ddEndMonth.Items.Add(new ListItem(months[i], (i + 1).ToString()));
            }
        }

        private void PopulateYears()
        {
            var thisyear = DateTime.Now.Year;
            for (int i = 2013; i <= thisyear; i++)
            {
                ddStartYear.Items.Add(new ListItem(i.ToString(), i.ToString()));
                ddEndYear.Items.Add(new ListItem(i.ToString(), i.ToString()));
            }
        }

        private void SecurePage()
        {
            if (!User.IsInRole(System.Configuration.ConfigurationManager.AppSettings["ADSecurityGroup"]))
                Response.Redirect("AccessDenied.aspx");
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            int round = 1;

            string start = ddStartMonth.SelectedItem.Text + " " + ddStartYear.SelectedValue;
            string end = ddEndMonth.SelectedItem.Text + " " + ddEndYear.SelectedValue;

            ltTimeSpan.Text = start.Equals(end) ? start : start + " - " + end;

            DateTime startDate = new DateTime(int.Parse(ddStartYear.SelectedValue), int.Parse(ddStartMonth.SelectedValue), 1);
            DateTime endDate = new DateTime(int.Parse(ddEndYear.SelectedValue), int.Parse(ddEndMonth.SelectedValue), DateTime.DaysInMonth(int.Parse(ddEndYear.SelectedValue), int.Parse(ddEndMonth.SelectedValue)));
            
            Classes.Reports.ReportResults results = Classes.Reports.GetSuddenCariacArrest(startDate, endDate);
            ltTotalSCA.Text = results.NumberOfCalls.ToString();
            ltPercentageSCA.Text = Decimal.Round(results.PercentageOnTime,round).ToString() + "%";

            results = Classes.Reports.GetCTAS(1, 8, startDate, endDate);
            ltTotalCTAS1.Text = results.NumberOfCalls.ToString();
            ltPercentageCTAS1.Text = Decimal.Round(results.PercentageOnTime,round).ToString() + "%";

            results = Classes.Reports.GetCTAS(2, 13,  startDate, endDate);
            ltTotalCTAS2.Text = results.NumberOfCalls.ToString();
            ltPercentageCTAS2.Text = Decimal.Round(results.PercentageOnTime, round).ToString() + "%";

            results = Classes.Reports.GetCTAS(3, 13, startDate, endDate);
            ltTotalCTAS3.Text = results.NumberOfCalls.ToString();
            ltPercentageCTAS3.Text = Decimal.Round(results.PercentageOnTime, round).ToString() + "%";

            results = Classes.Reports.GetCTAS(4, 20, startDate, endDate);
            ltTotalCTAS4.Text = results.NumberOfCalls.ToString();
            ltPercentageCTAS4.Text = Decimal.Round(results.PercentageOnTime, round).ToString() + "%";

            results = Classes.Reports.GetCTAS(5, 30, startDate, endDate);
            ltTotalCTAS5.Text = results.NumberOfCalls.ToString();
            ltPercentageCTAS5.Text = Decimal.Round(results.PercentageOnTime, round).ToString() + "%";

            phResults.Visible = true;
            phStart.Visible = false;
        }
    }
}