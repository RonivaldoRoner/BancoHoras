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
    public partial class EditFuncionario : Form
    {
        FuncionarioModel funcMod = new FuncionarioModel();
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
            
            string cpf = tb_CPF_Pesquisa.Text.Replace(",", "").Replace(".", "").Replace("-", "");
            funcBLL.ConsultaFuncByCPF(cpf);

           try
            {
                
                
            }catch(Exception erro)
            {
                MessageBox.Show("Erro ao localizar Funcionário. --- " + erro.Message);
            }
            
        }
        
        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
