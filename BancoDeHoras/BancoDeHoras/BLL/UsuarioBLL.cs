using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BancoDeHoras.Models;
using BancoDeHoras.DAL;

namespace BancoDeHoras.BLL
{
    class UsuarioBLL
    {
        UsuarioDAL userDAL = null;

        public void CreatTableBLL()
        {
            try
            {
                UsuarioDAL userDAL = new UsuarioDAL();
                userDAL.CreatTableUsuarios();
            }catch(Exception erro)
            {
                throw erro;
            }
        }

        public void CadUser(UsuarioModel userModel)
        {
            try
            {
                UsuarioDAL AddUser = new UsuarioDAL();
                AddUser.criaUser(userModel);
            }catch(Exception erro)
            {
                throw erro;
            }
        }

        public UsuarioModel DadosUsuario(string user, string pw)
        {
            UsuarioModel userModel = new UsuarioModel();
            try
            {
                userDAL = new UsuarioDAL();
                userModel = userDAL.buscaUser(user, pw);

            }catch(Exception erro)
            {
                throw erro;
            }
            return userModel;
        }
        
        public void CreatUserSstem(string userSystem, string pwSystem)
        {
            try
            {
                userDAL = new UsuarioDAL();
                userDAL.CriaUsuarioSystem(userSystem, pwSystem);
            }catch(Exception erro)
            {
                throw erro;
            }
        }
    }
}
