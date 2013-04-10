using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EMStats
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // authentication - users must be part of a specific AD Group (defined in web.config)
            if (!User.IsInRole(System.Configuration.ConfigurationManager.AppSettings["ADSecurityGroup"]))
                Response.Redirect("AccessDenied.aspx");

            // populate dropdown lists
            ddCTAS.DataSource = GetCTASs();
            ddCTAS.DataTextField = "Value";
            ddCTAS.DataValueField = "ID";
            ddCTAS.DataBind();

            ddCallType.DataSource = GetCallTypes();
            ddCallType.DataTextField = "Value";
            ddCallType.DataValueField = "ID";
            ddCallType.DataBind();

            ddVSA.DataSource = GetVSAs();
            ddVSA.DataTextField = "Value";
            ddVSA.DataValueField = "ID";
            ddVSA.DataBind();

            ddSymptomRelief.DataSource = GetSymptomReliefs();
            ddSymptomRelief.DataTextField = "Value";
            ddSymptomRelief.DataValueField = "ID";
            ddSymptomRelief.DataBind();

            ddIVAttempt.DataSource = GetIVAttempts();
            ddIVAttempt.DataTextField = "Value";
            ddIVAttempt.DataValueField = "ID";
            ddIVAttempt.DataBind();
         
        }

        // get entries for CTAS dropdown
        private List<CTASs> GetCTASs() {
            using (emsDBDataContext db = new emsDBDataContext())
            {
                var q = from c in db.CTASses
                        where c.Active == true
                        select c;
                return q.ToList();
            }
        }

        // get entries for IV Attempts dropdown
        private List<IVAttempts> GetIVAttempts()
        {
            using (emsDBDataContext db = new emsDBDataContext())
            {
                var q = from c in db.IVAttempts
                        where c.Active == true
                        select c;
                return q.ToList();
            }
        }

        //get entries for Symptom Relief dropdown
        private List<SymptomReliefs> GetSymptomReliefs()
        {
            using (emsDBDataContext db = new emsDBDataContext())
            {
                var q = from c in db.SymptomReliefs
                        where c.Active == true
                        select c;
                return q.ToList();
            }
        }

        // get entries for VSA dropdown
        private List<VSAs> GetVSAs()
        {
            using (emsDBDataContext db = new emsDBDataContext())
            {
                var q = from c in db.VSAs
                        where c.Active == true
                        select c;
                return q.ToList();
            }
        }

        // get entries for Call Types dropdown
        private List<CallTypes> GetCallTypes()
        {
            using (emsDBDataContext db = new emsDBDataContext())
            {
                var q = from c in db.CallTypes
                        where c.Active == true
                        select c;
                return q.ToList();
            }
        }

        // retrieves the username from windows authentication and trims the domain from it, leaving only the bare username
        private static string GetUserName()
        {
            String username = HttpContext.Current.User.Identity.Name.ToString();
            String domain = System.Configuration.ConfigurationManager.AppSettings["ADSecurityGroup"] + "\\"; // double backslash as an escape character
            username = username.Replace(domain, "");
            return username;
        }

        // submit the form!
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            // let's check the date. it should be valid through client-side validation, but let's make sure.
            DateTime parsedDate;
            if (DateTime.TryParseExact(txtDate.Text, "MM/dd/yyyy", null, System.Globalization.DateTimeStyles.None, out parsedDate))
            {
                using (emsDBDataContext db = new emsDBDataContext())
                {
                    // create the entry...
                    Entry entry = new Entry
                    {
                        Date = parsedDate,
                        CallNumber = txtCallNumber.Text,
                        T2 = TimeSpan.Parse(txtT2.Text),
                        T3 = TimeSpan.Parse(txtT3.Text),
                        T4 = TimeSpan.Parse(txtT4.Text),
                        CTAS = int.Parse(ddCTAS.SelectedValue),
                        CallType = int.Parse(ddCallType.SelectedValue),
                        VSA = int.Parse(ddVSA.SelectedValue),
                        SymptomRelief = int.Parse(ddSymptomRelief.SelectedValue),
                        IVAttempt = int.Parse(ddIVAttempt.SelectedValue),
                        DateEntered = DateTime.Now, // record the time that the record was put in
                        EnteredBy = GetUserName() // record who entered the record
                    };

                    db.Entries.InsertOnSubmit(entry);

                    try
                    {
                        db.SubmitChanges();
                    }
                    catch (Exception ex)
                    {
                        throw new Exception(ex.Message);
                    }

                    // let's reset the form!
                    txtDate.Text = txtCallNumber.Text = txtT2.Text = txtT3.Text = txtT4.Text = txtTDiff.Text = String.Empty;
                    ddCTAS.SelectedIndex = ddCallType.SelectedIndex = ddVSA.SelectedIndex = ddSymptomRelief.SelectedIndex = ddIVAttempt.SelectedIndex = 0;

                    // display the message that the entry was successfully entered.
                    Alert1.Text = "Call number " + txtCallNumber.Text + " successfully added!";
                    Alert1.AlertType = Alert.AlertTypes.Success;
                    Alert1.Visible = true;


                }
            }
            else // not a valid date
            {
                throw new Exception("This was not recognized as a valid date.");
            }
        }

    }
}