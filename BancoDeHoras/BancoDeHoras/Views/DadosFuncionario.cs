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

            EmpresaBLL empBLL = new EmpresaBLL();
            EmpresaModel empMod = new EmpresaModel();

            empMod = empBLL.DadosEmpresaBLL();

            tb_Nome_Emp.Text = empMod.Nome;
            tb_CNPJ.Text = empMod.CNPJ;

            FuncionarioBLL funcBLL = new FuncionarioBLL();
            FuncionarioModel funcMod = new FuncionarioModel();
            //funcMod = funcBLL
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
            FuncionarioBLL funcBLL = new FuncionarioBLL();
            funcBLL.CreatTableFuncionarioBLL();
            CadastroFunc cadFunc = new CadastroFunc();
            cadFunc.Show();
            this.Visible = false;
        }
    }
}
