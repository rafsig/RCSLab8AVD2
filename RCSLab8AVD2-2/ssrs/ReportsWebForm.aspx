<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ReportsWebForm.aspx.cs" Inherits="RCSLab8AVD2_2.ssrs.ReportsWebForm" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <rsweb:ReportViewer ID="ReportViewer1" ProcessingMode="Remote" runat="server"></rsweb:ReportViewer>
        </div>
         <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    </form>
   
</body>
</html>
