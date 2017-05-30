using BancoDeHoras.Models;
using System;
using BancoDeHoras.DAL;
using BancoDeHoras.Uteis;

namespace BancoDeHoras.BLL
{
    class RegistroDefinitivoBLL
    {
        RegistroDefinitivoDAL regDAL = null;

        public void CreateTableRegDefinitivo()
        {
            regDAL = new RegistroDefinitivoDAL();
            try
            {
                regDAL.CreateTableRegistro();
            }catch(Exception erro)
            {
                throw erro;
            }
        }

        public void AddRegDefinitivo(RegistroModel regMod)
        {
            ScanObjectModel scaMod = new ScanObjectModel();
            if (scaMod.VerificaRegBranco(regMod))
            {
                try
                {
                    regDAL = new RegistroDefinitivoDAL();
                    regDAL.AddRegistro(regMod);
                }catch(Exception erro)
                {
                    throw erro;
                }
            }     
                           
        }

        public RegistroModel UltimoRegistroBLL(int id)
        {
            try
            {
                regDAL = new RegistroDefinitivoDAL();
                return regDAL.UltimoRegistro(id);
            }catch(Exception erro)
            {
                throw erro;
            }
        }
        
    }
}
