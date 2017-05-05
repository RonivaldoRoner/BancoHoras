using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDeHoras.Models
{
    class UsuarioModel
    {
        string fk_cpf, usuario, pw, situacao;
        int tipo_Usuario;

        public string FK_CPF
        {
            get { return fk_cpf; }
            set { fk_cpf = value; }
        }

        public string Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }

        public string PW
        {
            get { return pw; }
            set { pw = value; }
        }

        public string Situacao
        {
            get { return situacao; }
            set { situacao = value; }
        }

        public int Tipo_Usuario
        {
            get { return tipo_Usuario; }
            set { tipo_Usuario = value; }
        }
    }
}
