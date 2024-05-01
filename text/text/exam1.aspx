<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="exam1.aspx.cs" Inherits="text.exam1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
       <div>
            <h1>隨機抽獎</h1>
            
            <asp:Repeater ID="rptPrizes" runat="server">
                <ItemTemplate>
                    <div>
                        <%# Eval("items") %>
                        <asp:Image ID="imgPrize" runat="server" ImageUrl='<%# Eval("IMAG") %>' />
                    </div>
                </ItemTemplate>
            </asp:Repeater>
            <asp:Button ID="BT" runat="server" Text="抽獎開始" OnClick="btnDraw_Click" />
            <hr />
            
            <h2>抽中的獎品：</h2>
            <asp:Label ID="lblSelectedPrize" runat="server" Text=""></asp:Label>
            <asp:Image ID="imgSelectedPrize" runat="server" />
            
            
        </div>
    </form>
</body>
</html>
