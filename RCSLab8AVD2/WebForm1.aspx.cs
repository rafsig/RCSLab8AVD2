using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Security.Principal;
using Microsoft.Reporting.WebForms;
using System.Net;

namespace RCSLab8AVD2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ReportViewer1.ShowCredentialPrompts = true;
            ReportViewer1.ServerReport.ReportServerUrl = new Uri("http://142.55.32.96/reportserver");
            ReportViewer1.ServerReport.ReportPath = "/Fall 2018/Rafael Sigwalt/ContactList";
            ReportViewer1.ServerReport.ReportServerCredentials = new ReportServerCredentials("student", "student", "");
        }
    }

    public class ReportServerCredentials : IReportServerCredentials
    {
        private string _userName;
        private string _password;
        private string _domain;

        public ReportServerCredentials(string userName, string password, string domain)
        {
            _userName = userName;
            _password = password;
            _domain = domain;
        }

        public WindowsIdentity ImpersonationUser
        {
            get
            {
                // Use default identity.
                return null;
            }
        }

        public ICredentials NetworkCredentials
        {
            get
            {
                // Use default identity.
                return new NetworkCredential(_userName, _password, _domain);
            }
        }

        public bool GetFormsCredentials(out Cookie authCookie, out string user, out string password, out string authority)
        {
            // Do not use forms credentials to authenticate.
            authCookie = null;
            user = password = authority = null;
            return false;
        }
    }
}