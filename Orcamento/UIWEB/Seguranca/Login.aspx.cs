using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using Orcamento.Modelos;
using Orcamento.BL;

public partial class Seguranca_Login : System.Web.UI.Page
{
    #region Load
    protected void Page_Load(object sender, EventArgs e)
    {
        txtLogin.Focus();
    }
    #endregion

    #region Propriedades

    private string LoginName
    {
        get { return txtLogin.Text; }
    }

    private string Senha
    {
        get { return txtSenha.Text; }
    }

    public const string orcamentoUsuario = "Orcamento.Usuario";

    #endregion

    #region Eventos

    /// <summary>
    /// Método do botão
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btnEnviar_Click(object sender, EventArgs e)
    {
        this.AutenticaUsuario();
    }


    #endregion

    #region Metodos

    #region Autentica Usuario
    private void AutenticaUsuario()
    {
        Usuario usuario = this.ObterAutenticacaoUsuario();

        if (usuario != null)
        {
            Session["orcamentoUsuario"] = usuario;

            var ticket = new FormsAuthenticationTicket(1, usuario.usuarioNome, DateTime.Now, DateTime.Now.AddHours(10),
                false, usuario.usuarioId.ToString());

            var cookie = new HttpCookie(FormsAuthentication.FormsCookieName, FormsAuthentication.Encrypt(ticket));
            Response.Cookies.Add(cookie);

            lblResultado.Text = "Usuario encontrado";
            Response.Redirect("~/Default.aspx");
        }
        else
        {
            lblResultado.Text = "Usuário não encontrado";
        }
    }
    #endregion

    #region Obter Autenticacao Usuario
    private Usuario ObterAutenticacaoUsuario()
    {
        UsuariosBL usuariosBl = new UsuariosBL();
        return usuariosBl.VerificaUsuario(LoginName, Senha);
    }
    #endregion

    #endregion
}