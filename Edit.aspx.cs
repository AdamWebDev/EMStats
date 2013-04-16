using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EMStats.Classes;
using System.Globalization;

namespace EMStats
{
    public partial class Edit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // authentication - users must be part of a specific AD Group (defined in web.config)
            if (!User.IsInRole(System.Configuration.ConfigurationManager.AppSettings["ADSecurityGroup"]))
                Response.Redirect("AccessDenied.aspx");

            
            int ID;
            if(int.TryParse(Request.QueryString["ID"].ToString(),out ID)) {
            
                System.Globalization.CultureInfo vCulture = (System.Globalization.CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
                vCulture.DateTimeFormat.ShortDatePattern = "MM/dd/yyyy";
                vCulture.DateTimeFormat.DateSeparator = "/";
                System.Threading.Thread.CurrentThread.CurrentCulture = vCulture;


                if (!Page.IsPostBack)
                {
                    // populate dropdown lists
                    ddCTAS.DataSource = EMStatsData.GetCTASs();
                    ddCTAS.DataTextField = "Value";
                    ddCTAS.DataValueField = "ID";
                    ddCTAS.DataBind();

                    ddCallType.DataSource = EMStatsData.GetCallTypes();
                    ddCallType.DataTextField = "Value";
                    ddCallType.DataValueField = "ID";
                    ddCallType.DataBind();

                    ddVSA.DataSource = EMStatsData.GetVSAs();
                    ddVSA.DataTextField = "Value";
                    ddVSA.DataValueField = "ID";
                    ddVSA.DataBind();

                    ddSymptomRelief.DataSource = EMStatsData.GetSymptomReliefs();
                    ddSymptomRelief.DataTextField = "Value";
                    ddSymptomRelief.DataValueField = "ID";
                    ddSymptomRelief.DataBind();

                    ddIVAttempt.DataSource = EMStatsData.GetIVAttempts();
                    ddIVAttempt.DataTextField = "Value";
                    ddIVAttempt.DataValueField = "ID";
                    ddIVAttempt.DataBind();


                    Entry entry = EMStatsData.GetEntry(ID);
                    if (entry != null)
                    {
                        txtDate.Text = entry.Date.ToString("MM/dd/yyyy");
                        txtCallNumber.Text = entry.CallNumber;
                        txtT2.Text = entry.T2.ToString();
                        txtT3.Text = entry.T3.ToString();
                        txtT4.Text = entry.T4.ToString();
                        ddCTAS.SelectedValue = entry.CTAS.ToString();
                        ddCallType.SelectedValue = entry.CallType.ToString();
                        ddVSA.SelectedValue = entry.VSA.ToString();
                        ddSymptomRelief.SelectedValue = entry.SymptomRelief.ToString();
                        ddIVAttempt.SelectedValue = entry.IVAttempt.ToString();
                        hdnID.Value = entry.ID.ToString();
                    }
                    else
                    {
                        Response.Redirect("~/Default.aspx");
                    }
                }
            }
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
                    var entry = (from q in db.Entries
                                where q.ID == int.Parse(hdnID.Value)
                                select q).SingleOrDefault();

                    if (entry != null)
                    {
                        entry.Date = parsedDate;
                        entry.CallNumber = txtCallNumber.Text;
                        entry.T2 = TimeSpan.Parse(txtT2.Text);
                        entry.T3 = TimeSpan.Parse(txtT3.Text);
                        entry.T4 = TimeSpan.Parse(txtT4.Text);
                        entry.CTAS = int.Parse(ddCTAS.SelectedValue);
                        entry.CallType = int.Parse(ddCallType.SelectedValue);
                        entry.VSA = int.Parse(ddVSA.SelectedValue);
                        entry.SymptomRelief = int.Parse(ddSymptomRelief.SelectedValue);
                        entry.IVAttempt = int.Parse(ddIVAttempt.SelectedValue);
                        entry.DateEntered = DateTime.Now; // record the time that the record was put in
                        entry.EnteredBy = EMStatsData.GetUserName(); // record who entered the record
                        db.SubmitChanges();

                        // display the message that the entry was successfully entered.
                        Alert1.Text = "Call number " + txtCallNumber.Text + " successfully updated!";
                        Alert1.AlertType = Alert.AlertTypes.Success;
                        Alert1.Visible = true;
                    }
                    else
                    {
                        throw new Exception("This record was not found.");
                    }
                }
            }
            else // not a valid date
            {
                throw new Exception("This was not recognized as a valid date.");
            }
        }
    }
}