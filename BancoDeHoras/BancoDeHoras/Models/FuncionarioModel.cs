using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDeHoras.Models
{
    class FuncionarioModel
    {
        string nome, cpf, fk_cnpj, email, telefone, login, senha, str_dt_Demissao;
        int id, tipo;
        DateTime dt_Admissao;
        DateTime dt_Demissao;
        

        public string CPF
        {
            get { return cpf; }
            set { cpf = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
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

        public string Login
        {
            get { return login; }
            set { login = value; }
        }

        public string Senha
        {
            get { return senha; }
            set { senha = value; }
        }

        public DateTime Dt_Admissao
        {
            get { return dt_Admissao; }
            set { dt_Admissao = value; }
        }

        public DateTime Dt_Demissao
        {
            get { return dt_Demissao; }
            set { dt_Demissao = value; }
        }

        public string FK_CNPJ
        {
            get { return fk_cnpj; }
            set { fk_cnpj = value; }
        }

        public string STR_dt_Demissao
        {
            get { return str_dt_Demissao; }
            set { str_dt_Demissao = value; }
        }

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public int Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }        
    }
}
