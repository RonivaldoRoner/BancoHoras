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
using BancoDeHoras.Uteis;

namespace BancoDeHoras.Views
{
    public partial class CadastroFunc : Form
    {
        public CadastroFunc()
        {
            InitializeComponent();

            EmpresaBLL empBLL = new EmpresaBLL();
            EmpresaModel empMod = new EmpresaModel();

            empMod = empBLL.DadosEmpresaBLL();

            tb_Nome_Emp.Text = empMod.Nome;
            tb_CNPJ.Text = empMod.CNPJ;

        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {            
            this.Visible = false;
        }

        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
            FuncionarioModel funcMod = new FuncionarioModel();
            FuncionarioBLL funcBLL = new FuncionarioBLL();                                  

            funcMod.FK_CNPJ = tb_CNPJ.Text.Replace(".", "").Replace(",", "").Replace("/", "").Replace("-", "");
            funcMod.Nome = tb_Nome.Text;
            funcMod.CPF = tb_CPF_Func.Text.Replace(".", "").Replace(",", "").Replace("-", "");
            funcMod.Email = tb_Email.Text;
            funcMod.Telefone = tb_Telefone.Text.Replace("(", "").Replace(")", "").Replace("-", "");
            funcMod.Dt_Admissao = Convert.ToDateTime(tb_Data_Admissao.Text);                                     
            
            try
            {
                funcBLL.CadFuncionarioBLL(funcMod);
            }catch (Exception erro)
            {
                MessageBox.Show("Não foi posssível cadastrar funcionario." + erro);
            }

            DadosFuncionario dadosFunc = new DadosFuncionario();
            dadosFunc.Show();

            this.Visible = false;          
                        
        }
    }
}
