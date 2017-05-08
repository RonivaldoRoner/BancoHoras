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
    public partial class Principal : Form
    {
        int tipo_user;
        public Principal(int tipo_user)
        {
            InitializeComponent();
            this.tipo_user = tipo_user;            
            this.WindowState = FormWindowState.Maximized;
                        

        }
        //cadastro de empresa
        private void empresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DadosEmpresa empresa = new DadosEmpresa();
            empresa.Show();
        }

        private void btn_Cad_Responsavel_Click(object sender, EventArgs e)
        {
            DadosRespons consultResp = new DadosRespons();
            consultResp.Show();
        }

        private void btn_Cad_Funcionario_Click(object sender, EventArgs e)
        {
            DadosFuncionario dadosFunc = new DadosFuncionario();
            dadosFunc.Show();
            
        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditarUsuario edtUser = new EditarUsuario();
            edtUser.Show();
        }
    }
}
