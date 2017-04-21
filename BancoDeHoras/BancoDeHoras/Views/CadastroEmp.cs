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
using System.Security.Cryptography;
using BancoDeHoras.Uteis;

namespace BancoDeHoras.Views
{
    public partial class CadastroEmp : Form
    {
        public CadastroEmp()
        {
            InitializeComponent();
        }

        private void CadastroEmp_Load(object sender, EventArgs e)
        {
            

        }

        private void btn_Gravar_Click(object sender, EventArgs e)
        {
            var senhaCript = Criptografia.Criptografar(tb_Senha.Text);

            var senhaDecript = Criptografia.Descriptografar(Criptografia.Criptografar(tb_Senha.Text));

            EmpresaModel empMod = new EmpresaModel();
            
            //Dados da empresa.
            empMod.Nome = tb_Nome_Emp.Text;
            string cnpj = tb_CNPJ.Text.Replace(".", "").Replace("/", "").Replace("-", "").Replace(",","");
            empMod.CNPJ = cnpj;            
            empMod.Endereco = tb_Endereco.Text;
            empMod.End_Num = Convert.ToInt32(tb_Num.Text);
            empMod.End_Comp = tb_Complem.Text;
            empMod.Bairro = tb_Bairro.Text;
            empMod.Cidade = tb_Cidade.Text;
            empMod.Estado = tb_UF.Text;
            empMod.CEP = tb_CEP.Text;
            empMod.Telefone = tb_Telefone.Text;

            ResponsavelModel respModel = new ResponsavelModel();

            // Dados do Responsavel pela empresa
            respModel.Nome_Resp = tb_Nome_Resp.Text;
            string cpf = tb_CPF.Text.Replace(".", "").Replace("-", "").Replace(",", "");
            respModel.CPF = cpf;
            respModel.Email = tb_Email.Text;

            try
            {
                EmpresaBLL empBLL = new EmpresaBLL();
                empBLL.CreatDB();                
                empBLL.CreatTbEmpresa();
                empBLL.cadEmpresaBLL(empMod);
                MessageBox.Show("Informações da empresa inserido ");

                //Cria tabela e cadastrainformações na tabela responsavel.
                ResponsavelBLL respBLL = new ResponsavelBLL();
                respBLL.CreatTBbRespons();
                respBLL.cadResponsavelBLL(respModel);

                MessageBox.Show("Dados gravados com sucesso.");

            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao gravar dados da Empresa." + erro);
            }

            tb
        }

        private void btn_Voltar_Click(object sender, EventArgs e)
        {
            Login logUser = new Login();
            logUser.Show();
            this.Visible = false;           
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EmpresaBLL empBLL = new EmpresaBLL();
            empBLL.CreatDB();
            empBLL.CreatTbEmpresa();

            MessageBox.Show("Banco de dados e Tabela criado com sucesso.");
        }
    }
}
