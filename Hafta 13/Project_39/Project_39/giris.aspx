<%@ Page Language="C#" AutoEventWireup="true" CodeFile="giris.aspx.cs" Inherits="giris" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <!--YORUM-->
        <div style=" text-align:center">
            <asp:Label ID="Label1" runat="server" Text="Öğrenci No:"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server" style="margin-left: 17px" Width="169px"></asp:TextBox>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Sifre:"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server" style="margin-left: 60px; margin-bottom: 0px; margin-right: 0px;" Width="161px" TextMode="Password"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Giris" Text="Giriş" Height="34px" style="margin-bottom: 0px" Width="58px" />
            <br />
            <asp:Label ID="Label3" runat="server" ForeColor="#CC6699" Text="Mesaj" Font-Size="Larger"></asp:Label>
        </div>
        
    </form>
    </body>
</html>
