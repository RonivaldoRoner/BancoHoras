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
    public partial class CadastroRespons : Form
    {
        public CadastroRespons()
        {
            InitializeComponent();
            EmpresaBLL empBLL = new EmpresaBLL();
            EmpresaModel modEmp = new EmpresaModel();
            modEmp = empBLL.DadosEmpresaBLL();
            tb_Empresa.Text = modEmp.Nome;
            tb_CNPJ.Text = modEmp.CNPJ;

        }

        private void btn_Gravar_Click(object sender, EventArgs e)
        {
            ResponsavelModel respModel = new ResponsavelModel();
            respModel.FK_CNPJ = tb_CNPJ.Text.Replace(".", "").Replace(",", "").Replace("/", "").Replace("-", "");
            respModel.Nome_Resp = tb_Nome_Resp.Text;
            respModel.CPF = tb_CPF_Resp.Text.Replace(",", "").Replace(".", "").Replace("-", "");
            respModel.Email = tb_Email_Resp.Text;
            respModel.Telefone = tb_Tel_Resp.Text.Replace("(", "").Replace(")", "").Replace("-", "");

            try
            {
                ResponsavelBLL respBLL = new ResponsavelBLL();
                respBLL.CreatTBbRespons();
                MessageBox.Show("Tabela Criada ");
                respBLL.cadResponsavelBLL(respModel);

            } catch(Exception erro)
            {
                MessageBox.Show("Erro na gravação dos dados" + erro);
            };
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
