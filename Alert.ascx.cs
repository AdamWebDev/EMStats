using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EMStats
{

    
    public partial class Alert : System.Web.UI.UserControl
    {
        
        public enum AlertTypes { Warning, Error, Success, Information}    

        public string Text
        {
            set { ltMessage.Text = value; }
        }

        public AlertTypes AlertType
        {
            set
            {
                if (value == AlertTypes.Warning)
                    pnAlert.CssClass = "alert";
                else if (value == AlertTypes.Error)
                    pnAlert.CssClass = "alert alert-error";
                else if (value == AlertTypes.Success)
                    pnAlert.CssClass = "alert alert-success";
                else if (value == AlertTypes.Information)
                    pnAlert.CssClass = "alert alert-info";
            }
        }
        

     
        

        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}