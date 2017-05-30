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
        public bool VerificaRegBranco(RegistroModel regMod)
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

            if (string.IsNullOrEmpty(regMod.Tipo_Reg))
            {
                ok = false;
                throw new Exception("Favor informar Tipo de Registro.");
            }           
            return ok;
        }

        public bool VerificaFuncBranco(FuncionarioModel funcMod)
        {
            bool ok = true;

            if (string.IsNullOrEmpty(funcMod.CPF))
            {
                ok = false;
                throw new Exception("Favor informar CPF");
            }

            if (string.IsNullOrEmpty(funcMod.Nome))
            {
                ok = false;
                throw new Exception("Favor informar Nome.");
            }

            if (string.IsNullOrEmpty(funcMod.Email))
            {
                ok = false;
                throw new Exception("Favor informar Email.");
            }

            if (string.IsNullOrEmpty(funcMod.Telefone))
            {
                ok = false;
                throw new Exception("Favor informar Telefone.");
            }

            if (string.IsNullOrEmpty(funcMod.Dt_Admissao.ToString()))
            {
                ok = false;
                throw new Exception("Favor informar Data de Admissão.");
            }

            return ok;
        }

        public bool VerificaRespBranco(ResponsavelModel respMod)
        {
            bool ok = true;

            if (string.IsNullOrEmpty(respMod.Nome_Resp))
            {
                ok = false;
                throw new Exception("Favor informar Nome");
            }

            if (string.IsNullOrEmpty(respMod.CPF))
            {
                ok = false;
                throw new Exception("Favor informar CPF.");
            }

            if (string.IsNullOrEmpty(respMod.Email))
            {
                ok = false;
                throw new Exception("Favor informar Email.");
            }

            if (string.IsNullOrEmpty(respMod.Telefone))
            {
                ok = false;
                throw new Exception("Favor informar Telefone.");
            }

            return ok;
        }

        public bool VerificaEmpresaBranco(EmpresaModel empMod)
        {
            bool ok = true;

            if (string.IsNullOrEmpty(empMod.Nome))
            {
                ok = false;
                throw new Exception("Favor informar Nome.");
            }

            if (string.IsNullOrEmpty(empMod.CNPJ))
            {
                ok = false;
                throw new Exception("Favor informar CNPJ.");
            }

            if (string.IsNullOrEmpty(empMod.Endereco))
            {
                ok = false;
                throw new Exception("Favor informar Endereço.");
            }

            if (string.IsNullOrEmpty(empMod.End_Num.ToString()))
            {
                ok = false;
                throw new Exception("Favor informar Número.");
            }

            if (string.IsNullOrEmpty(empMod.Bairro))
            {
                ok = false;
                throw new Exception("Favor informar Bairro.");
            }

            if (string.IsNullOrEmpty(empMod.Cidade))
            {
                ok = false;
                throw new Exception("Favor informar Cidade.");
            }

            if (string.IsNullOrEmpty(empMod.Estado))
            {
                ok = false;
                throw new Exception("Favor informar Estado.");
            }

            if (string.IsNullOrEmpty(empMod.CEP))
            {
                ok = false;
                throw new Exception("Favor informar CEP.");
            }

            return ok;
        }

    }
}
