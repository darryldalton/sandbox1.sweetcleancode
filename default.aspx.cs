using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace sandbox1.sweetcleancode
{
    public partial class _default : System.Web.UI.Page
    {
        protected string environment = "not set";
        protected void Page_Load(object sender, EventArgs e)
        {
            //environment = System.Configuration.ConfigurationManager.AppSettings["environment"];
            environment = @Environment.GetEnvironmentVariable("environment");
            
        }
    }
}