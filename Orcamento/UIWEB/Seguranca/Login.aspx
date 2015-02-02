<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Seguranca_Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Tela de Login</title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="login">
            <h1>Página de Login</h1>
            <div>
                <table>
                    <tr>
                        <td>Login: </td>
                        <td>
                            <asp:TextBox ID="txtLogin" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>Senha: </td>
                        <td>
                            <asp:TextBox ID="txtSenha" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td> <asp:Button ID="btnEnviar" runat="server" Text="Entrar" OnClick="btnEnviar_Click" /> </td>
                        <td> <asp:Label ID="lblResultado" runat="server">Resultado</asp:Label></td>
                    </tr>
                </table>
            </div>

        </div>
    </form>
</body>
</html>
