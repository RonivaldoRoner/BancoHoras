using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BancoDeHoras.Uteis
{
    class CalculaHE
    {
        public static TimeSpan CalcMinutos(TimeSpan he)
        {
            int horas = Convert.ToInt32(he.Hours);
            int minutos = Convert.ToInt32(he.Minutes);            

            if((minutos > 14) && (minutos < 45))
            {
                minutos = 30;
            }else
            {
                if(minutos > 44)
                {
                    horas += 1;
                    minutos = 0;
                }else
                {
                    minutos = 0;
                }
            }          

            TimeSpan horaExtra = new TimeSpan(0, horas, minutos, 0);

            return horaExtra;
        }
    }
}
