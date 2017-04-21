using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace BancoDeHoras.Models
{
    class EmpresaModel
    {
        string cnpj, nome, endereco, end_Comp, bairro, cidade,
            estado, cep, telefone;
        int end_Num;

        public string CNPJ
        {
            get { return cnpj; }
            set { cnpj = value; }
        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }
        public int End_Num
        {
            get { return end_Num; }
            set { end_Num = value; }
        }
        public string End_Comp
        {
            get { return end_Comp; }
            set { end_Comp = value; }
        }
        public string Bairro
        {
            get { return bairro; }
            set { bairro = value; }
        }
        public string Cidade
        {
            get { return cidade; }
            set { cidade = value; }
        }
        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }
        public string CEP
        {
            get { return cep; }
            set { cep = value; }
        }
        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }              

    }
}
