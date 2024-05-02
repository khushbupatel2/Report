<%@ Page Language="C#" AutoEventWireup="true" Inherits="MvcReportViewer.MvcReportViewer, MvcReportViewer" %>
<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=11.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript" src="//code.jquery.com/jquery-1.11.0.min.js"></script>
    <script type="text/javascript" src="//code.jquery.com/jquery-migrate-1.2.1.min.js"></script>
</head>
<body>
    <form id="reportForm" runat="server">
    <div>
        <asp:ScriptManager runat="server" ID="ScriptManager"></asp:ScriptManager>
        <rsweb:ReportViewer ID="ReportViewer" ClientIDMode="Predictable" runat="server"></rsweb:ReportViewer>
    </div>
    </form>

   
</body>
</html>
