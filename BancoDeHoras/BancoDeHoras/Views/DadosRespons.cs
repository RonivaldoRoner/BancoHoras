using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BancoDeHoras.Models;
using BancoDeHoras.BLL;

namespace BancoDeHoras.Views
{
    public partial class DadosRespons : Form
    {        
        public DadosRespons()
        {
            InitializeComponent();

            EmpresaModel empMod = new EmpresaModel();
            EmpresaBLL empBLL = new EmpresaBLL();

            empMod = empBLL.DadosEmpresaBLL();

            tb_Empresa.Text = empMod.Nome;
            tb_CNPJ.Text = empMod.CNPJ;

        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void btn_Novo_Click(object sender, EventArgs e)
        {
            CadastroRespons cadResp = new CadastroRespons();
            cadResp.Show();
            this.Visible = false;             
            
        }
    }
}
