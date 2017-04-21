using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BancoDeHoras.Uteis;

namespace BancoDeHoras.Views
{
    public partial class CadastroFunc : Form
    {
        public CadastroFunc()
        {
            InitializeComponent();

           /* Mascaras masc = new Mascaras();

            if(tb_Admissao.Text == null)
            {
                string dataVazia = "00000000";
                tb_Admissao.Text = masc.MascData(dataVazia);
            }else
            {
                tb_Admissao.Text = masc.MascData(tb_Admissao.Text);
            }*/
        }
    }
}
