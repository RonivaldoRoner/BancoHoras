using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BancoDeHoras.Models;

namespace BancoDeHoras.Uteis
{
    class ScanObjectModel
    {
        public bool OMRegistros(RegistroModel regMod)
        {
            bool ok = true;
            if (string.IsNullOrEmpty(regMod.Responsavel))
            {
                ok = false;
                throw new Exception("Favor selecionar Responsável");
            }

            if (string.IsNullOrEmpty(regMod.Descricao))
            {
                ok = false;
                throw new Exception("Favor informar Descrição.");
            }

            if (string.IsNullOrEmpty(regMod.Data_Reg.ToString()))
            {
                ok = false;
                throw new Exception("Favor informar Data do Registro.");
            }

            if (string.IsNullOrEmpty(regMod.Inicio_HE.ToString()))
            {
                ok = false;
                throw new Exception("Favor informar Inicio do Registro.");                
            }

            if (string.IsNullOrEmpty(regMod.Fim_HE.ToString()))
            {
                ok = false;
                throw new Exception("Favor informar Final do Registro.");
            }            
            return ok;
        }

    }
}
