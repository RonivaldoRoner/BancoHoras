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
using System.Collections;

namespace BancoDeHoras.Views
{
    public partial class EditFuncionario : Form
    {
        FuncionarioModel funcMod = new FuncionarioModel();
        int idFunc;
        public EditFuncionario()
        {
            InitializeComponent();

            EmpresaBLL empBLL = new EmpresaBLL();
            EmpresaModel empMod = new EmpresaModel();

            empMod = empBLL.DadosEmpresaBLL();            

            tb_Nome_Emp.Text = empMod.Nome;
            tb_CNPJ.Text = empMod.CNPJ;
            tb_Nome_Emp.Enabled = false;
            tb_CNPJ.Enabled = false;
            tb_Nome_Pesquisa.Text = null;
            tb_CPF_Pesquisa.Text = null;       
        }

        private void btn_Pesquisar_Func_Click(object sender, EventArgs e)
        {
            FuncionarioBLL funcBLL = new FuncionarioBLL();
            
            string cpf = tb_CPF_Pesquisa.Text.Replace(",", "").Replace(".", "").Replace("-", "").Replace(" ","");
            try
            {

                if (string.IsNullOrEmpty(cpf))
                {                    
                    ArrayList listaFunc = new ArrayList();
                    listaFunc = funcBLL.ListaFuncionarios();
                    int index;
                    string nomeCurto;
                    foreach(string nome in listaFunc)
                    {                        
                        index = nome.IndexOf(" ");
                        nomeCurto = nome.Substring(0, index);
                        if(nomeCurto == tb_Nome_Pesquisa.Text)
                        {
                            funcMod = funcBLL.ConsultaFuncByNome(nome);
                        }                                          
                    }
                }else
                {
                    funcMod = funcBLL.ConsultaFuncByCPF(cpf);
                }
                if (!string.IsNullOrEmpty(funcMod.Nome))
                {                           
                    idFunc = funcMod.ID;

                    tb_Nome.Text = funcMod.Nome;
                    tb_CPF.Text = funcMod.CPF;
                    tb_Email.Text = funcMod.Email;
                    tb_Celular.Text = funcMod.Telefone.Replace(" ", "");
                    tb_Admissao.Text = funcMod.Dt_Admissao.ToString("ddMMyyyy").Replace("-", "/");

                    if (!string.IsNullOrEmpty(funcMod.STR_dt_Demissao))
                    {
                        tb_Demissao.Text = funcMod.Dt_Demissao.ToString("ddMMyyyy").Replace("-", "/");
                    }
                    else
                    {
                        tb_Demissao.Text = null;
                    }
                }else
                {
                    MessageBox.Show("Funcionário não encontrado.");
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Funcionário não encontrado. --- " + erro.Message);
            }
                                
        }
        
        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            DadosFuncionario dadosFunc = new DadosFuncionario();
            dadosFunc.Show();
            this.Close();
        }

        private void btn_Gravar_Click(object sender, EventArgs e)
        {
            
            try
            {
                FuncionarioModel funcioMod = new FuncionarioModel();

                funcioMod.ID = idFunc;
                funcioMod.CPF = tb_CPF_Pesquisa.Text.Replace(",", "").Replace(".", "").Replace("-", "");
                MessageBox.Show("CPF: " + funcioMod.CPF);
                funcioMod.Nome = tb_Nome.Text;
                funcioMod.Email = tb_Email.Text;
                funcioMod.Telefone = tb_Celular.Text.Replace("(", "").Replace(")", "").Replace(" ", "").Replace("-", "");
                funcioMod.Dt_Admissao = Convert.ToDateTime(tb_Admissao.Text);
                string dt_Demissao = tb_Demissao.Text.Replace("/", "").Replace(" ","");

                if (!string.IsNullOrEmpty(dt_Demissao))
                {
                    MessageBox.Show("Data Demissão: -- " + dt_Demissao);
                    DateTime demissao = Convert.ToDateTime(tb_Demissao.Text);
                    funcioMod.Dt_Demissao = demissao;
                    //funcioMod.STR_dt_Demissao = tb_Demissao.Text;
                }                                                                                 
                if (cb_Gerente.Checked)
                {
                    funcioMod.Tipo = 1;
                }
                else
                {
                    funcioMod.Tipo = 2;
                }
                FuncionarioBLL funcBLL = new FuncionarioBLL();
                funcBLL.EditFuncionario(funcioMod);

                MessageBox.Show("Dados do Funcionário editados com sucesso.");
            }
            catch(Exception erro)
            {
                MessageBox.Show("Erro ao editar Funcionário" + erro);
            }           
        }
    }
}
