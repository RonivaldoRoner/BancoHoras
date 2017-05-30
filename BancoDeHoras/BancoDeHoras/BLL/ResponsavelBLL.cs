using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BancoDeHoras.DAL;
using BancoDeHoras.Models;
using BancoDeHoras.Uteis;

namespace BancoDeHoras.BLL
{
    class ResponsavelBLL
    {
        ResponsavelDAL respDAL = null;

        public void CreatTBbRespons()
        {
            respDAL = new ResponsavelDAL();
            respDAL.CreatTableResponsavel();
        }

        public void cadResponsavelBLL(ResponsavelModel respModel)
        {
            ScanObjectModel scanResp = new ScanObjectModel();
            if (scanResp.VerificaRespBranco(respModel))
            {
                try
                {
                    respDAL = new ResponsavelDAL();
                    respDAL.cadResponsavel(respModel);
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

        public ResponsavelModel consultResponsavel()
        {
            ResponsavelModel respModel = new ResponsavelModel();

            try
            {
                respDAL = new ResponsavelDAL();
                respModel = respDAL.consultaResponsavel();

            }catch(Exception erro)
            {
                throw erro;
            }
            return respModel;
        }

        public void edtResponsBLL(ResponsavelModel respMod)
        {
            ScanObjectModel scanResp = new ScanObjectModel();
            if (scanResp.VerificaRespBranco(respMod))
            {
                try
                {
                    respDAL = new ResponsavelDAL();
                    respDAL.editResponsavel(respMod);
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
