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
        public Principal()
        {
            InitializeComponent();
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

        private void btn_Cad_Usuario_Click(object sender, EventArgs e)
        {
            CadUsuario cadUser = new CadUsuario();
            cadUser.Show();
        }
    }
}
