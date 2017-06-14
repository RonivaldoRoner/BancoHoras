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
using BancoDeHoras.DAL;
using System.Collections;

namespace BancoDeHoras.Views
{
    public partial class ConsultaIndividual : Form
    {
        EmpresaBLL empBLL = new EmpresaBLL();
        EmpresaModel empMod = new EmpresaModel();
        FuncionarioBLL funcBLL = new FuncionarioBLL();
        FuncionarioModel funcMod = new FuncionarioModel();

        public ConsultaIndividual()
        {
            InitializeComponent();

            empMod = empBLL.DadosEmpresaBLL();
            funcMod = funcBLL.ConsultaFuncByID(Login.id_user);

            tb_Nome_Emp.Text = empMod.Nome;
            tb_CNPJ.Text = empMod.CNPJ;
            tb_Nome.Text = funcMod.Nome;
            tb_CPF_Func.Text = funcMod.CPF;

                    
                                                       

        }

        private void btn_Filtra_Data_Click(object sender, EventArgs e)
        {

        }      


    }
}
