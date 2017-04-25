using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDeHoras.Models
{
    class ValidaUsuarioModel
    {
        string user, senha;
        int tela;
        

        public string User
        {
            get { return user; }
            set { user = value; }
        }

        public string Senha
        {
            get { return senha; }
            set { senha = value; }
        }

        public int Tela
        {
            get { return tela; }
            set { tela = value; }
        }

       
    }
}
