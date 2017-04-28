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
        public EditFuncionario()
        {
            InitializeComponent();

            EmpresaBLL empBLL = new EmpresaBLL();
            EmpresaModel empMod = new EmpresaModel();

            empMod = empBLL.DadosEmpresaBLL();

            tb_Nome_Emp.Text = empMod.Nome;
            tb_CNPJ.Text = empMod.CNPJ;          
        }

        private void btn_Pesquisar_Func_Click(object sender, EventArgs e)
        {

        }
    }
}
