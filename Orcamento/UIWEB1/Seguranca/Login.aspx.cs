using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Orcamento.BL;
using Orcamento.Modelos;

public partial class Seguranca_Login : System.Web.UI.Page
{
    #region Propriedade

    private string loginName
    {
        get { return txtLogin.Text; }
    }

    private string senha
    {
        get { return txtSenha.Text; }
    }

    //public const string orcamentoUsuario = "Orcamento.Usuario";

    #endregion

    #region Load
    protected void Page_Load(object sender, EventArgs e)
    {
        txtLogin.Focus();
    }
    #endregion

    #region Eventos

    #region Botão Login
    protected void btnLogin_Click(object sender, EventArgs e)
    {
        this.AutenticaUsuario();
    }
    #endregion

    #region Autentica o Usuario

    private void AutenticaUsuario()
    {
        Usuario usuario = this.ObterAutenticacaoUsuario();

        if (usuario != null)
        {
            //Session["orcamentoUsuario"] = usuario;

            //var ticket = new FormsAuthenticationTicket(1, usuario.UserName,
            //    DateTime.Now, DateTime.Now.AddHours(10), false,
            //    usuario.UserID.ToString());

            //var cookie = new HttpCookie(FormsAuthentication.FormsCookieName, FormsAuthentication.Encrypt(ticket));
            //Response.Cookies.Add(cookie);

            Response.Redirect("~/default.aspx");
            //lblResultado.Text = "Usuario encontrado";

        }
        else
        {
            lblResultado.Text = "Usuario não encontrado, tente novamente.";
        }
    }

    private Usuario ObterAutenticacaoUsuario()
    {
        UsuariosBL usuariosBl = new UsuariosBL();
        return usuariosBl.VerificaUsuario(loginName, senha);
    }

    #endregion

    #endregion


}