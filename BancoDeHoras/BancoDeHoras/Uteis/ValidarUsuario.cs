using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDeHoras.Uteis
{
    class ValidarUsuario
    {
        public Boolean validUser(string user, string senha)
        {
            string usuario = "sa";
            string senhaAdmin = "123456";

            if((user == usuario)&&(senhaAdmin == senha))
            {
                return true;
            }else
            {
                return false;
            }
        }
    }
}
