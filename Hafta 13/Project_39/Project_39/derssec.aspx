<%@ Page Language="C#" AutoEventWireup="true" CodeFile="derssec.aspx.cs" Inherits="derssec" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="DropDownList1" runat="server" Height="20px" Width="210px">
            </asp:DropDownList>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="margin-left: 28px" Text="Ekle" />
        </div>
    </form>
</body>
</html>
