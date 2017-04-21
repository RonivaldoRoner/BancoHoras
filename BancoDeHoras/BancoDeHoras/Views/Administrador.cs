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
using BancoDeHoras.DAL;
using BancoDeHoras.Models;
using BancoDeHoras.Uteis;


namespace BancoDeHoras.Views
{
    public partial class Administrador : Form
    {
        
        public Administrador()
        {
            InitializeComponent();
        }

        private void Administrador_Load(object sender, EventArgs e)
        {
            
            dadosEmpresa();          
        }

                
        public void dadosEmpresa()
        {            
            EmpresaModel empModel = new EmpresaModel();
            FuncionarioModel funcModel = new FuncionarioModel();

            try
            {

                Mascaras masc = new Mascaras();
                EmpresaBLL empBLL = new EmpresaBLL();
                empModel = empBLL.DadosEmpresaBLL();
               

                lb_Emp_Nome.Text = empModel.Nome;
                lb_Emp_CNPJ.Text =  masc.MascCNPJ(empModel.CNPJ);
                lb_Emp_Tel.Text = masc.MascTel(empModel.Telefone);

                FuncionarioBLL funcBLL = new FuncionarioBLL();
                

                lb_Responsavel.Text = funcModel.Nome;
                lb_CPF.Text = masc.MascCPF(funcModel.CPF);
                lb_Email.Text = funcModel.Email;
                             
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro: " + erro);
            }


        }

        private void btn_Cad_Func_Click(object sender, EventArgs e)
        {
            CadastroFunc cadFunc = new CadastroFunc();
            cadFunc.Show();
            this.Visible = false;
        }
    }
}
