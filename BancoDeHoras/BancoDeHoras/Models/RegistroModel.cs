using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDeHoras.Models
{
    class RegistroModel
    {
        DateTime data_Reg;
        TimeSpan qtd_Horas, inicio_HE, fim_HE;
        string responsavel, descricao;
        int fk_id_Func;

        public DateTime Data_Reg
        {
            get { return data_Reg; }
            set { data_Reg = value; }
        }

        public TimeSpan Qtd_Horas
        {
            get { return qtd_Horas; }
            set { qtd_Horas = value; }
        }

        public TimeSpan Inicio_HE
        {
            get { return inicio_HE; }
            set { inicio_HE = value; }
        }

        public TimeSpan Fim_HE
        {
            get { return fim_HE; }
            set { fim_HE = value; }
        }

        public string Responsavel
        {
            get { return responsavel; }
            set { responsavel = value; }
        }

        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }
       
        public int FK_Id_Func
        {
            get { return fk_id_Func; }
            set { fk_id_Func = value; }
        }
        
    }
}
