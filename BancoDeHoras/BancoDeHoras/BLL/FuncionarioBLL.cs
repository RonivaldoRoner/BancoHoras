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

        public FuncionarioModel consultaFuncBLL(int id_Func)
        {            
            try
            {
                funcDAL = new FuncionarioDAL();
                FuncionarioModel funcMod = new FuncionarioModel();
                funcMod = funcDAL.consultaFunc(id_Func);

                return funcMod;
            }
            catch(Exception erro)
            {
                throw erro;
            }
        }
        public FuncionarioModel verificaFunc(string cpf)
        {
            try
            {
                funcDAL = new FuncionarioDAL();
                FuncionarioModel funcMod = new FuncionarioModel();
                funcMod = funcDAL.verificaFunc(cpf);

                return funcMod;

            }catch(Exception erro)
            {
                throw erro;
            }
        }
    }
}
