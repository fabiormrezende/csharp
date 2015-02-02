<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Seguranca_Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Tela de Login</title>
    <link href="../CSS/Estilo.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div class ="login">
            <table>
                <tr>
                    <td>Login:</td>
                    <td>
                        <asp:TextBox ID="txtLogin" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Senha:</td>
                    <td>
                        <asp:TextBox ID="txtSenha" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="btnLogin" runat="server" Text="Entrar" OnClick="btnLogin_Click" />
                    </td>
                    <td>
                        <asp:Label ID="lblResultado" runat="server" Text="Resultado"></asp:Label>
                    </td>
                </tr>
            </table>

        </div>
    </form>
</body>
</html>
