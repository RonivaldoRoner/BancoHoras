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
        EmpresaBLL empBLL = new EmpresaBLL();
        EmpresaModel empMod = new EmpresaModel();

        FuncionarioModel funcMod = new FuncionarioModel();
        FuncionarioBLL funcBLL = new FuncionarioBLL();

        public CadastroFunc()
        {
            InitializeComponent();
            
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
            
            string cpf = tb_CPF_Func.Text.Replace(".", "").Replace(",", "").Replace("-", "");
            funcMod = funcBLL.verificaFunc(cpf);         

            if (string.IsNullOrEmpty(funcMod.CPF))
            {                
                cadastrar_Func();
            }
            else
            {
                DateTime dt_Adm_Comp = Convert.ToDateTime(tb_Data_Admissao.Text);
                if(DateTime.Compare(dt_Adm_Comp, funcMod.Dt_Admissao) <= 0)
                {
                    MessageBox.Show("Funcionário encontrado com data de Admissão igual ou posterior.");
                }else
                {                                      
                    if (string.IsNullOrEmpty(funcMod.STR_dt_Demissao))
                    {
                        MessageBox.Show("Funcionário já cadastrado e ativo.");
                    }
                    else
                    {                        
                        cadastrar_Func();
                    }
                }

                
            }

            CadUsuario cadUser = new CadUsuario(funcMod.CPF);
            
            cadUser.Show();

            this.Visible = false;          
                       
        }

        private void cadastrar_Func()
        {         
            funcMod.FK_CNPJ = tb_CNPJ.Text.Replace(".", "").Replace(",", "").Replace("/", "").Replace("-", "");
            funcMod.Nome = tb_Nome.Text;
            funcMod.CPF = tb_CPF_Func.Text.Replace(".", "").Replace(",", "").Replace("-", "");
            funcMod.Email = tb_Email.Text;
            funcMod.Telefone = tb_Telefone.Text.Replace("(", "").Replace(")", "").Replace("-", "");
            funcMod.Dt_Admissao = Convert.ToDateTime(tb_Data_Admissao.Text);
            try
            {
                funcBLL.CadFuncionarioBLL(funcMod);
                MessageBox.Show("Cadastrado com sucesso.");
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao inserir dados." + erro);
            }
        }
    }
}
