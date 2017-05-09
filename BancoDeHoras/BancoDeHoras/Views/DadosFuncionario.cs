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
    public partial class DadosFuncionario : Form
    {
        public DadosFuncionario()
        {
            InitializeComponent();

            if(Login.tipo_usuario != 1)
            {
                this.btn_Cadastrar.Visible = false;
                this.btn_Editar.Visible = false;
            }

            FuncionarioBLL funcBLL = new FuncionarioBLL();
            funcBLL.CreatTableFuncionarioBLL();

            EmpresaBLL empBLL = new EmpresaBLL();
            EmpresaModel empMod = new EmpresaModel();

            empMod = empBLL.DadosEmpresaBLL();

            tb_Nome_Emp.Text = empMod.Nome;
            tb_CNPJ.Text = empMod.CNPJ;                      
            
            FuncionarioModel funcMod = new FuncionarioModel();
            funcMod = funcBLL.consultaFuncBLL(Login.id_user);

            try
            {
                tb_Nome_Func.Text = funcMod.Nome;
                tb_CPF.Text = funcMod.CPF;
                tb_Email.Text = funcMod.Email;
                tb_Telefone.Text = funcMod.Telefone.Replace(" ","");
                tb_Admissao.Text = funcMod.Dt_Admissao.ToString("ddMMyyyy").Replace("-", "/");
                
                if(funcMod.STR_dt_Demissao != null)
                {
                    tb_Demissao.Text = funcMod.Dt_Demissao.ToString("ddMMyyyy").Replace("-", "/");
                }              

            }
            catch(Exception erro)
            {
                MessageBox.Show("Não foi possivel recuperar informações. --- " + erro);
            }

            
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            EditFuncionario edtFunc = new EditFuncionario();
            edtFunc.Show();
            this.Visible = false;
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            
        }

        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {            
            CadastroFunc cadFunc = new CadastroFunc();
            cadFunc.Show();
            this.Visible = false;
        }
    }
}
