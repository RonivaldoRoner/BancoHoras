﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BancoDeHoras.DAL;
using BancoDeHoras.Models;
using System.Data;

namespace BancoDeHoras.BLL
{
    class EmpresaBLL
    {
        EmpresaDAL empresaDAL = null;

        public void CreatDB(string userSystem, string senhaSystem)
        {
            empresaDAL = new EmpresaDAL();
            empresaDAL.creatDB(userSystem, senhaSystem);            
        }
        
        public void CreatTbEmpresa()
        {
            empresaDAL = new EmpresaDAL();
            empresaDAL.CreattableEmpresa();
        }
       
        public void cadEmpresaBLL(EmpresaModel empModel)
        {
            try
            {
                empresaDAL = new EmpresaDAL();
                empresaDAL.cadEmpresa(empModel);                
                
            }catch(Exception erro)
            {
                throw erro;
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
            try
            {
                empresaDAL = new EmpresaDAL();
                empresaDAL.editEmpresa(empModel); 
                
            }catch(Exception erro)
            {
                throw erro; 
            }
        }
        
    }
}
