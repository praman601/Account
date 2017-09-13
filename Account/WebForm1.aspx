<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Account.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>

                <tr>
                    <td>
                        <asp:Label ID="Label8" runat="server" Text="Account number"></asp:Label>
                    </td>
                    <td>

                        <asp:Label ID="Label1" runat="server" Text="Label1"></asp:Label>
                        </td>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text="Label2"></asp:Label>

                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label9" runat="server" Text="CustomerName"></asp:Label>
                    </td>
                    <td>

                        <asp:Label ID="Label3" runat="server" Text="Label3"></asp:Label>
                        </td>
                    <td>

                        <asp:Label ID="Label4" runat="server" Text="Label4"></asp:Label>

                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label10" runat="server" Text="Balance"></asp:Label>

                    </td>
                    <td>
                        <asp:Label ID="Label5" runat="server" Text="Label5"></asp:Label>
                        </td>


                        <td>
                            <asp:Label ID="Label6" runat="server" Text="Label6"></asp:Label>
                    </td>

                </tr>
                <tr>
                    <td colspan="3">
                        <asp:Button ID="Button1" runat="server" Text="Transfer 10 from A1 to A2" OnClick="Button1_Click" />
                    </td>
                </tr>

            </table>
            <asp:Label ID="Label7" runat="server" Text=""></asp:Label>
 </div>
    </form>
</body>
</html>
