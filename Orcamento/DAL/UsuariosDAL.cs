using System;
using System.Linq;
using Orcamento.Modelos;

namespace Orcamento.DAL
{
    public class UsuariosDAL
    {

        #region Valida Usuario na tela de login

        /// <summary>
        /// Método para verificar se login e senha estão corretos
        /// </summary>
        /// <param name="login">Login do Usuário</param>
        /// <param name="senha">Senha do Usuário</param>
        /// <returns></returns>
        public Usuario VerificaUsuario(string login, string senha)
        {
            ModelosDataContext us = new ModelosDataContext();

            try
            {
                var user = (from usuarios in us.Usuarios
                            where usuarios.usuarioNome == login
                            && usuarios.usuarioSenha == senha
                            && usuarios.usuarioAtivo == 1
                            select usuarios).FirstOrDefault();
                return user;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

    }
}
