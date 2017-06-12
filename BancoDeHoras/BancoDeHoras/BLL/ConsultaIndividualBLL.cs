using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BancoDeHoras.DAL;
using BancoDeHoras.Models;
using System.Collections;

namespace BancoDeHoras.BLL
{
    class ConsultaIndividualBLL
    {
        ConsultasDAL consultaInd = null;

        public ArrayList ConsultIdReg(int id_User)
        {
            try
            {
                consultaInd = new ConsultasDAL();
                return consultaInd.Consult_Id_Registros(id_User);
            }catch(Exception erro)
            {
                throw erro;
            }
        }

        public RegistroModel ConsultRegistros(int id_Reg)
        {
            try
            {
                consultaInd = new ConsultasDAL();
                return consultaInd.Consult_Registro(id_Reg);
            }catch(Exception erro)
            {
                throw erro;
            }
        }
        

    }
}
