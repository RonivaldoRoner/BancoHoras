using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BancoDeHoras.DAL;
using BancoDeHoras.Models;

namespace BancoDeHoras.BLL
{
    class FuncionarioBLL
    {
        FuncionarioDAL funcDAL = null;

        public void CreatTableFuncionarioBLL()
        {
            funcDAL = new FuncionarioDAL();
            funcDAL.CreatTableFuncionario();
        }
        public void CadFuncionarioBLL(FuncionarioModel funcModel)
        {

            try
            {
                funcDAL = new FuncionarioDAL();
                funcDAL.AddUser(funcModel);

            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
    }
}
