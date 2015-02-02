using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UIWEB.MasterPage
{
    public partial class MasterPage : System.Web.UI.MasterPage
    {
        #region Load
        protected void Page_Load(object sender, EventArgs e)
        {
            this.VerificaLogin();
        }
        #endregion

        #region Metodos
        private void VerificaLogin()
        {
            if (Session["orcamentoUsuario"] == null)
            {
                Response.Redirect("~/seguranca/Login.aspx");
            }
        }
        #endregion
    }
}