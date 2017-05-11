using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDeHoras.Models
{
    class UsuarioModel
    {
        //If(tipo_Usuario == 1){Usuario administrador}
        //if(tipo_Usuario == 2){Usuario simples}
        string usuario, pw, situacao;
        int tipo_Usuario, fk_id_Func, id_user;


        public int FK_ID_Func
        {
            get { return fk_id_Func; }
            set { fk_id_Func = value; }
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

        public int ID_User
        {
            get { return id_user; }
            set { id_user = value; }
        }
    }
}
