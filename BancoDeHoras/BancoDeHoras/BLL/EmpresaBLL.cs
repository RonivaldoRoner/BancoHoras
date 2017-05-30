using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BancoDeHoras.DAL;
using BancoDeHoras.Models;
using System.Data;
using BancoDeHoras.Uteis;

namespace BancoDeHoras.BLL
{
    class EmpresaBLL
    {
        EmpresaDAL empresaDAL = null;

        public void CreatDB()
        {
            try
            {
                empresaDAL = new EmpresaDAL();
                empresaDAL.CreatDB();
            }
            catch(Exception erro)
            {
                throw erro;
            }
                      
        }
        
        public void CreatTbEmpresa()
        {
            empresaDAL = new EmpresaDAL();
            empresaDAL.CreattableEmpresa();
        }
       
        public void cadEmpresaBLL(EmpresaModel empModel)
        {
            ScanObjectModel scanMod = new ScanObjectModel();

            if (scanMod.VerificaEmpresaBranco(empModel))
            {
                try
                {
                    empresaDAL = new EmpresaDAL();
                    empresaDAL.CadEmpresa(empModel);
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

        public EmpresaModel DadosEmpresaBLL( )
        {
            EmpresaModel empModel = new EmpresaModel();

            try
            {
                empresaDAL = new EmpresaDAL();
                empModel = empresaDAL.DadosEmpresaDAL();

            }
            catch (Exception erro)
            {
                throw erro;
            }

            return empModel;

        }

        public void editEmpresaBLL(EmpresaModel empModel)
        {
            ScanObjectModel scanMod = new ScanObjectModel();

            if (scanMod.VerificaEmpresaBranco(empModel))
            {
                try
                {
                    empresaDAL = new EmpresaDAL();
                    empresaDAL.EditEmpresa(empModel);
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
        
    }
}
