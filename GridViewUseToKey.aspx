<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GridViewUseToKey.aspx.cs" Inherits="gridview_data_show.GridViewForms.GridViewUseToKey" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Search Employee Details </title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Empno St"></asp:Label>
            <asp:TextBox ID="txtstrt" runat="server"></asp:TextBox>
            <asp:Label ID="Label2" runat="server" Text="Empno "></asp:Label>
            <asp:TextBox ID="txtend" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
        </div>
        <div>
            <asp:GridView ID="GridView1" runat="server" >

            </asp:GridView>
        </div>
    </form>
</body>
</html>
