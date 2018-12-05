using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RCSLab8AVD2_2.ssrs
{
    public partial class ReportsWebForm : System.Web.UI.Page
    {

        public String ReportServerURL { get; set; }
        public String ReportPath { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            ReportViewer1.ServerReport.ReportServerUrl = new Uri(ReportServerURL);
            ReportViewer1.ServerReport.ReportPath = ReportPath;
        }
    }
}