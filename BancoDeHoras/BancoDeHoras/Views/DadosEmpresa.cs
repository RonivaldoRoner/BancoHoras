using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancoDeHoras.Views
{
    public partial class DadosEmpresa : Form
    {
        public DadosEmpresa()
        {
            InitializeComponent();
            tb_CNPJ.Text = "02996771000106";
        }

        private void btn_Gravar_Click(object sender, EventArgs e)
        {
            LoginAdmin logAdmin = new LoginAdmin();
            logAdmin.Show();            
            this.Visible = false;
        }

        private void btn_Voltar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
