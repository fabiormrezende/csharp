using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Orcamento.BL;

namespace UIWEB
{
    public partial class Usuarios : System.Web.UI.Page
    {
        #region Propriedades
        private int? usuarioID
        {
            get
            {
                int usuarioId;
                if (Int32.TryParse(ViewState["usuarioID"] + "", out usuarioId))
                {
                    return usuarioId;
                }

                return null;
            }
            set { ViewState["usuarioID"] = value; }
        }
        #endregion

        #region Load
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.CarregaGrid();
            }

        }
        #endregion

        #region Metodos

        #region CarregaGrid

        private void CarregaGrid()
        {
            UsuariosBL carregaBl = new UsuariosBL();
            grdUsuarios.DataSource = carregaBl.CarregaUsuarios();
            grdUsuarios.DataBind();
        }

        #endregion

        #endregion
    }
}