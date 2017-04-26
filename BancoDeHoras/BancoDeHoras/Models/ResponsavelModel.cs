using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDeHoras.Models
{
    class ResponsavelModel
    {
        string nome_Resp, fk_cnpj, cpf, email, telefone;

        public string Nome_Resp
        {
            get { return nome_Resp; }
            set { nome_Resp = value; }
        }

        public string CPF
        {
            get { return cpf; }
            set { cpf = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }

        public string FK_CNPJ
        {
            get { return fk_cnpj; }
            set { fk_cnpj = value; }
        }
    }
}
