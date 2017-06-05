using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;


namespace BancoDeHoras.Models
{
    class RegistroModel
    {
        DateTime data_Reg;
        TimeSpan qtd_Horas, inicio_HE, fim_HE;
        string responsavel, descricao, tipo_Reg, saldo_Horas;
        int fk_id_Func, id_Reg, saldo_Dias;


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

        public int ID_Reg
        {
            get { return id_Reg; }
            set { id_Reg = value; }
        }

        public string Tipo_Reg
        {
            get { return tipo_Reg; }
            set { tipo_Reg = value; }
        }

       public string Saldo_Horas
        {
            get { return saldo_Horas; }
            set { saldo_Horas = value; }
        }

        public int Saldo_Dias
        {
            get { return saldo_Dias; }
            set { saldo_Dias = value; }
        }
    }
}