<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="UserControlDemo.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 255px">
    <form id="form1" runat="server">
        <div>
           Selected Date:  <UcCal:CalendarUserControl ID="CalendarUserControl1" runat="server" selectedDate="4/5/2020" />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Ok" />
        </div>
    </form>
</body>
</html>
