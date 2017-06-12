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
        public static string FormataHora(TimeSpan Registro)
        {
            string hrFormat;
            try
            {
                int horas = Registro.Hours;
                int minut = Registro.Minutes;
                

                if((horas < 10)&&(horas > -10))
                {
                    hrFormat = "0" + horas;
                }else
                {
                    hrFormat = horas.ToString();
                }
                if(minut < 10)
                {
                    hrFormat += ":00";
                }else
                {
                    hrFormat += ":"+minut;
                }

            }catch(Exception erro)
            {
                throw erro;
            }

            return hrFormat;
        }                    

        public static TimeSpan CalcMinutos(TimeSpan he)
        {
            int horas = Convert.ToInt32(he.Hours);
            int minutos = Convert.ToInt32(he.Minutes);

            if ((minutos > 14) && (minutos < 45))
            {
                minutos = 30;
            }
            else
            {
                if (minutos > 44)
                {
                    horas += 1;
                    minutos = 0;
                }
                else
                {
                    minutos = 0;
                }
            }

            TimeSpan horaExtra = new TimeSpan(0, horas, minutos, 0);
            return horaExtra;
        }

        public static Tuple<int, string> Qtd_Horas_Superior_24(TimeSpan qtdHoras, int qtdDias)
        {
            try
            {
                TimeSpan diaHoras = TimeSpan.Parse("23:59");

                while (qtdHoras > diaHoras)
                {
                    qtdDias++;
                    qtdHoras = qtdHoras.Subtract(diaHoras);
                    qtdHoras = qtdHoras.Subtract(TimeSpan.Parse("00:01"));
                }

                string strQtdHoras = qtdHoras.ToString();
                return new Tuple<int, string>(qtdDias, strQtdHoras);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public static Tuple<int, string> Qtd_Horas_Inferior_24(TimeSpan qtdHoras, int qtdDias)
        {
            try
            {
                TimeSpan diaHoras = TimeSpan.Parse("23:59");

                while (qtdHoras < TimeSpan.Parse("00:00"))
                {
                    qtdDias--;
                    qtdHoras = qtdHoras.Add(diaHoras);
                    qtdHoras = qtdHoras.Add(TimeSpan.Parse("00:01"));
                }

                string strQtdHoras = qtdHoras.ToString();
                return new Tuple<int, string>(qtdDias, strQtdHoras);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

    }
}