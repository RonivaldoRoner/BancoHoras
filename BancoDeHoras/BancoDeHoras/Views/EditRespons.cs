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
    public partial class EditRespons : Form
    {
        ResponsavelModel respMod = new ResponsavelModel();
        ResponsavelBLL respBLL = new ResponsavelBLL();

        public EditRespons()
        {
            InitializeComponent();

            try
            {
                EmpresaModel empMod = new EmpresaModel();
                EmpresaBLL empBLL = new EmpresaBLL();

                empMod = empBLL.DadosEmpresaBLL();
                if (empMod != null)
                {
                    tb_Empresa.Text = empMod.Nome;
                    tb_CNPJ.Text = empMod.CNPJ;
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Favor cadastrar Empresa." + erro);
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
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao acessar informações no Banco de Dados.  -- " + erro);
            }
        }
            

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            DadosRespons dadosResp = new DadosRespons();
            dadosResp.Show();
            this.Visible = false;

        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            try
            {
                respMod.Nome_Resp = tb_Nome_Resp.Text;
                respMod.CPF = tb_CPF_Resp.Text.Replace(",", "").Replace(".", "").Replace("-", "");
                respMod.Email = tb_Email_Resp.Text;
                respMod.Telefone = tb_Tel_Resp.Text.Replace("(", "").Replace(")", "").Replace("-", "");

                respBLL.edtResponsBLL(respMod);

                MessageBox.Show("Dados gravados com sucesso.");
            }
            catch(Exception erro)
            {
                MessageBox.Show("Erro na atualização dos dados." + erro);
            }        
           
            
        }
    }
}
