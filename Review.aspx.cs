using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Globalization;
namespace EMStats
{
    public partial class Review : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SecurePage();

            if (!IsPostBack)
            {
                PopulateMonths();
                PopulateYears();
            }
            PopulateEntries();
        }

        private void PopulateMonths() {
            var months = CultureInfo.CurrentCulture.DateTimeFormat.MonthNames;
            for (int i = 0; i < months.Length-1; i++)
            {
                ddMonth.Items.Add(new ListItem(months[i], (i+1).ToString()));
            }
        }

        private void PopulateYears()
        {
            var thisyear = DateTime.Now.Year;
            for (int i = 2013; i <= thisyear; i++)
            {
                ddYear.Items.Add(new ListItem(i.ToString(), i.ToString()));
            }
        }

        private void PopulateEntries()
        {
            var month = int.Parse(ddMonth.SelectedValue);
            var year = int.Parse(ddYear.SelectedValue);
            using (emsDBDataContext db = new emsDBDataContext())
            {
                var q = db.EntryDetails
                        .Where(d => d.Date.Month == month && d.Date.Year == year)
                        .OrderBy(d => d.CallNumber);
                rptStats.DataSource = q.ToList();
                rptStats.DataBind();
            }
        }

        public string SecondstoHours(object seconds)
        {
            TimeSpan span = new TimeSpan(TimeSpan.TicksPerSecond * (int)seconds);
            String time = span.Hours.ToString("00") + ":" + span.Minutes.ToString("00") + ":" + span.Seconds.ToString("00");
            return time;
        }

        private void SecurePage()
        {
            if (!User.IsInRole(System.Configuration.ConfigurationManager.AppSettings["ADSecurityGroup"]))
                Response.Redirect("AccessDenied.aspx");
        }

        protected void rptStats_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            RepeaterItem item = e.Item;
            if((item.ItemType == ListItemType.Item) || (item.ItemType == ListItemType.AlternatingItem)) 
            {
                Literal ltDiff = e.Item.FindControl("rawDiff") as Literal;
                int seconds = int.Parse(ltDiff.Text);
                int minutes = seconds / 60;

                Literal ltCTAS = e.Item.FindControl("ltCTAS") as Literal;
                string CTAS = ltCTAS.Text;

                WarningIcon icon = e.Item.FindControl("WarningIcon") as WarningIcon;

                if (CTAS.Equals("CTAS 5") && minutes > 30)
                    icon.Visible = true;

            }
        }

        
    }

}