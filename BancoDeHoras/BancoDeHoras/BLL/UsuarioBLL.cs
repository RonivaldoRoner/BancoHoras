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
                AddUser.CriaUsuario(userModel);
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
                userModel = userDAL.ValidaUsuario(user, pw);
                return userModel;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }        

        public UsuarioModel BuscaUsuario(int fk_id_Func)
        {
            UsuarioModel userMod = new UsuarioModel();
            try
            {
                userDAL = new UsuarioDAL();
                userMod = userDAL.BuscaUsuario(fk_id_Func);
                return userMod;
            }catch(Exception erro)
            {
                throw erro;
            }
        }

        public void EditaUsuario(UsuarioModel userMod)
        {
            try
            {
                userDAL = new UsuarioDAL();
                userDAL.EditaUsuario(userMod);
            }catch(Exception erro)
            {
                throw erro;
            }
        }
    }
}
