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
using BancoDeHoras.Models;

namespace BancoDeHoras.Views
{
    public partial class DadosEmpresa : Form
    {
        public DadosEmpresa()
        {
            InitializeComponent();
            EmpresaBLL empBLL = new EmpresaBLL();
            EmpresaModel empMod = new EmpresaModel();

            empMod = empBLL.DadosEmpresaBLL();

            tb_Nome_Emp.Text = empMod.Nome;
            tb_CNPJ.Text = empMod.CNPJ;
            tb_Endereco.Text = empMod.Endereco;
            tb_Num.Text = empMod.End_Num.ToString();
            tb_Complem.Text = empMod.End_Comp;
            tb_Bairro.Text = empMod.Bairro;
            tb_Cidade.Text = empMod.Cidade;
            tb_UF.Text = empMod.Estado;
            tb_CEP.Text = empMod.CEP;
            tb_Telefone.Text = empMod.Telefone.Replace(" ","");

        }

        private void btn_Gravar_Click(object sender, EventArgs e)
        {
            CadastroEmp cadEmp = new CadastroEmp();
            cadEmp.Show();           
            this.Visible = false;
        }

        private void btn_Voltar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
