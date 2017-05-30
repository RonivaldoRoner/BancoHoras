using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BancoDeHoras.DAL;
using BancoDeHoras.Models;
using System.Data;
using System.Collections;
using BancoDeHoras.Uteis;


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
            ScanObjectModel scanFunc = new ScanObjectModel();
            if (scanFunc.VerificaFuncBranco(funcModel))
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
            }else
            {
                throw new Exception("Todos os campos devem ser preenchidos.");
            }

        }

        public FuncionarioModel ConsultaFuncByID(int id_Func)
        {            
            try
            {
                funcDAL = new FuncionarioDAL();
                FuncionarioModel funcMod = new FuncionarioModel();
                funcMod = funcDAL.VerificaFuncID(id_Func);

                return funcMod;
            }
            catch(Exception erro)
            {
                throw erro;
            }
        }

        public FuncionarioModel ConsultaFuncByCPF(string cpf)
        {
            try
            {
                funcDAL = new FuncionarioDAL();
                FuncionarioModel funcMod = new FuncionarioModel();
                funcMod = funcDAL.VerificaFuncCPF(cpf);

                return funcMod;

            }catch(Exception erro)
            {
                throw erro;
            }
        }

        public FuncionarioModel ConsultaFuncByNome(string nome)
        {
            try
            {
                funcDAL = new FuncionarioDAL();
                FuncionarioModel funcMod = new FuncionarioModel();
                funcMod = funcDAL.VerificaFuncNome(nome);

                return funcMod;
            }catch(Exception erro)
            {
                throw erro;
            }
        }             

        public ArrayList ALGerente()
        {
            try
            {
                funcDAL = new FuncionarioDAL();
                return funcDAL.ArrayList();
            }catch(Exception erro)
            {
                throw erro;
            }
        }

        public ArrayList ListaFuncionarios()
        {
            try
            {
                funcDAL = new FuncionarioDAL();
                return funcDAL.ListaFuncionarios();
            }catch(Exception erro)
            {
                throw erro;
            }
        }

        public void EditFuncionario(FuncionarioModel funcMod)
        {
            ScanObjectModel scanFunc = new ScanObjectModel();
            if (scanFunc.VerificaFuncBranco(funcMod))
            {
                try
                {
                    funcDAL = new FuncionarioDAL();
                    funcDAL.EditFunc(funcMod);
                }
                catch (Exception erro)
                {
                    throw erro;
                }
            }
            else
            {
                throw new Exception("Todos os campos devem ser preenchidos.");
            }
            
        }
    }
}
