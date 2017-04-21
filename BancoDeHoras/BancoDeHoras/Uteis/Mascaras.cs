using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDeHoras.Uteis
{
    class Mascaras
    {
        public string MascCNPJ(string cnpj)
        {
            string formatCNPJ = "";

            if (cnpj.Length == 14)
            {
                formatCNPJ = cnpj.Insert(2, ".").Insert(6, ".").Insert(10, "/").Insert(15, "-");

            }
                                        
            
            return formatCNPJ;
        }

        public string MascTel(string telefone)
        {
            string formatTelefone = "";

            if (telefone.Length == 11)
            {
                formatTelefone = telefone.Insert(0, "(").Insert(4, ")").Insert(9,"-");
            }


            return formatTelefone;
        }

        public string MascCEP(string cep)
        {
            string formatCEP = "";

            if(cep.Length == 8)
            {
                formatCEP = cep.Insert(5, "-");
            }

            return formatCEP;
        }

        public string MascCPF(string cpf)
        {
            string formatCPF = "";
            if(cpf.Length == 11)
            {
                formatCPF = cpf.Insert(3, ".").Insert(7, ".").Insert(11, "-");
            }

            return formatCPF;
        }

        public string MascData(string data)
        {
            string formatData = "";
            formatData = data.Insert(2, "/").Insert(5, "/");
            return formatData;
        }
    }
}
