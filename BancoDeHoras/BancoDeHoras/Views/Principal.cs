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
            if(Login.tipo_usuario != 1)
            {
                btn_Reg_Analise.Enabled = false;
                btn_Geral.Enabled = false;
            }                  
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

        private void Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void btn_Novo_Reg_Click(object sender, EventArgs e)
        {
            CadRegistros novoRegistro = new CadRegistros();
            novoRegistro.Show();
        }

        private void btn_Reg_Analise_Click(object sender, EventArgs e)
        {
            RegEmAnalise regAnalise = new RegEmAnalise();
            regAnalise.Show();
        }

        private void btn_Individual_Click(object sender, EventArgs e)
        {

        }

        private void btn_Geral_Click(object sender, EventArgs e)
        {

        }
    }
}
