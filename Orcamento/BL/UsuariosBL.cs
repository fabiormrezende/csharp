using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Orcamento.DAL;
using Orcamento.Modelos;

namespace Orcamento.BL
{
    public class UsuariosBL
    {

        #region Verifca Usuario

        public Usuario VerificaUsuario(string login, string senha)
        {
            UsuariosDAL usuariosDal = new UsuariosDAL();
            return usuariosDal.VerificaUsuario(login, senha);
        }

        #endregion

    }
}
