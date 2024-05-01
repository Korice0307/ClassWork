<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="HomeWork2.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>作業2</title>
    <style>
        h2{
            text-align:center;
        }
        #wapper{
            border:solid 2px;
            width:400px;
            height:400px;
            margin:20px auto;
            text-align:center;
        }
        #button1{
            
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <h2>註冊</h2>
        <div id="wapper">
            <asp:TextBox ID="TextBox1" runat="server" Height="25px" Width="230px"></asp:TextBox>
            <br />
            <asp:TextBox ID="TextBox2" runat="server" Height="25px" Width="230px"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" Text="註冊" Height="25px" Width="115px" OnClick="Button1_Click" />
            <hr />
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
