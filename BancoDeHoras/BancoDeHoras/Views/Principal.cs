using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BancoDeHoras.BLL;

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
            EmpresaBLL empBLL = new EmpresaBLL();
            empBLL.CreatTbEmpresa();
            DadosEmpresa empresa = new DadosEmpresa();
            empresa.Show();
        }

        private void btn_Cad_Responsavel_Click(object sender, EventArgs e)
        {
            ResponsavelBLL respBLL = new ResponsavelBLL();
            respBLL.CreatTBbRespons();
            DadosRespons consultResp = new DadosRespons();
            consultResp.Show();
        }

        private void btn_Cad_Funcionario_Click(object sender, EventArgs e)
        {
            FuncionarioBLL funcBLL = new FuncionarioBLL();
            funcBLL.CreatTableFuncionarioBLL();
            DadosFuncionario dadosFunc = new DadosFuncionario();
            dadosFunc.Show();
            
        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditarUsuario edtUser = new EditarUsuario();
            edtUser.Show();
        }

        private void Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
