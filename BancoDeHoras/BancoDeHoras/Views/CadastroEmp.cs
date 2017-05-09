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

        private void CadastroEmp_Load(object sender, EventArgs e) {   }

        private void btn_Gravar_Click(object sender, EventArgs e)
        {          

            EmpresaModel empMod = new EmpresaModel();
            
            //Dados da empresa.
            empMod.Nome = tb_Nome_Emp.Text;            
            empMod.CNPJ = tb_CNPJ.Text.Replace(".", "").Replace("/", "").Replace("-", "").Replace(",", "");
            empMod.Endereco = tb_Endereco.Text;
            empMod.End_Num = Convert.ToInt32(tb_Num.Text);
            empMod.End_Comp = tb_Complem.Text;
            empMod.Bairro = tb_Bairro.Text;
            empMod.Cidade = tb_Cidade.Text;
            empMod.Estado = tb_UF.Text;
            empMod.CEP = tb_CEP.Text.Replace("-","");
            empMod.Telefone = tb_Telefone.Text.Replace("(","").Replace(")","").Replace("-","");
                                                                    
            try
            {
                EmpresaBLL empBLL = new EmpresaBLL();
                //empBLL.CreatDB();                
                //empBLL.CreatTbEmpresa();
                empBLL.cadEmpresaBLL(empMod);
                MessageBox.Show("Informações da empresa inserido ");                                                
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao gravar dados da Empresa." + erro);
            }

            DadosEmpresa empresa = new DadosEmpresa();
            empresa.Show();
            this.Visible = false;            
        }

        private void btn_Voltar_Click(object sender, EventArgs e)
        {
            DadosEmpresa empresa = new DadosEmpresa();
            empresa.Show();
            this.Visible = false;           
        }
                              
    }
}
