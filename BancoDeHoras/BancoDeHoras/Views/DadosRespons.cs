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
    public partial class DadosRespons : Form
    {
        ResponsavelModel respMod = new ResponsavelModel();
        ResponsavelBLL respBLL = new ResponsavelBLL();        

        public DadosRespons()
        {
            InitializeComponent();
            
            if(Login.tipo_usuario != 1)
            {
                this.btn_Editar.Enabled = false;
                this.btn_Novo.Enabled = false;
            }                                  

            try
            {
                EmpresaModel empMod = new EmpresaModel();
                EmpresaBLL empBLL = new EmpresaBLL();
                
                empMod = empBLL.DadosEmpresaBLL();
                if(empMod != null)
                {
                    tb_Empresa.Text = empMod.Nome;
                    tb_CNPJ.Text = empMod.CNPJ;
                }                               
            }
            catch(Exception erro)
            {
                MessageBox.Show("Favor cadastrar Empresa. --- " + erro);
            }            

            try
            {
                respMod = respBLL.consultResponsavel();

                if (respMod != null)
                {
                    tb_Nome_Resp.Text = respMod.Nome_Resp;
                    tb_CPF_Resp.Text = respMod.CPF;
                    tb_Email_Resp.Text = respMod.Email;
                    tb_Tel_Resp.Text = respMod.Telefone.Replace(" ", "");
                }                                
            }
            catch(Exception erro)
            {
                MessageBox.Show("Favor cadastrar Responsável. --- " + erro);
            }
                                    
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void btn_Novo_Click(object sender, EventArgs e)
        {
            respMod = respBLL.consultResponsavel();

            if (string.IsNullOrEmpty(respMod.CPF))
            {
                CadastroRespons cadResp = new CadastroRespons();
                cadResp.Show();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Já existe Responsavel Cadastrado.");
            }                                
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            EditRespons edtResp = new EditRespons();
            edtResp.Show();
            this.Visible = false;
        }
    }
}
