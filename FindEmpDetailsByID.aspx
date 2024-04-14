<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FindEmpDetailsByID.aspx.cs" Inherits="gridview_data_show.FindEmpDetailsByID" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="EmpID"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
        </div>

        <asp:GridView ID="GridView1" runat="server"></asp:GridView>
    </form>
</body>
</html>

