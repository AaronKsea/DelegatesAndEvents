<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CalendarUserControl.ascx.cs" Inherits="UserControlDemo.CalendarUserControl" %>
<asp:TextBox ID="txtDate" runat="server" Width="115px"></asp:TextBox>
<asp:ImageButton ID="ImgBtn" runat="server" 
    ImageUrl="~/Images/Calendar.png" onclick="ImgBtn_Click" />
<asp:Calendar ID="Calendar1" runat="server" onselectionchanged="Calendar1_SelectionChanged">
</asp:Calendar>