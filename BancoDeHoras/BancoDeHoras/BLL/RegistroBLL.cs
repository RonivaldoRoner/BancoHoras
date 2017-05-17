using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BancoDeHoras.Models;
using BancoDeHoras.DAL;

namespace BancoDeHoras.BLL
{
    class RegistroBLL
    {
        RegistroDAL regDAL = null;

        public void CreateTableReg()
        {
            try
            {
                regDAL = new RegistroDAL();
                regDAL.CreateTableRegistro();
            }catch(Exception erro)
            {
                throw erro;
            }
        }

        public void NovoRegistro(RegistroModel regMod)
        {
            regDAL = new RegistroDAL();
            try
            {
                regDAL.AddRegistro(regMod);
            }catch(Exception erro)
            {
                throw erro;
            }
        }
    }
}
