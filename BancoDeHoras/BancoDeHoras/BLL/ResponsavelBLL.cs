using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BancoDeHoras.DAL;
using BancoDeHoras.Models;

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
            try
            {
                respDAL = new ResponsavelDAL();
                respDAL.cadResponsavel(respModel);
            }
            catch (Exception erro)
            {
                throw erro;
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
    }
}
