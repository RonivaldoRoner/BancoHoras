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
        public DadosRespons()
        {
            InitializeComponent();
                                   

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
                MessageBox.Show("Favor cadastrar Empresa." + erro);
            }
            

            try
            {
                ResponsavelModel respMod = new ResponsavelModel();
                ResponsavelBLL respBLL = new ResponsavelBLL();
                respMod = respBLL.consultResponsavel();

                if(respMod != null)
                {
                    tb_Nome_Resp.Text = respMod.Nome_Resp;
                    tb_CPF_Resp.Text = respMod.CPF;
                    tb_Email_Resp.Text = respMod.Email;
                    tb_Tel_Resp.Text = respMod.Telefone;
                }

                
            }
            catch(Exception erro)
            {
                MessageBox.Show("Favor cadastrar Responsável.");
            }
                                    
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void btn_Novo_Click(object sender, EventArgs e)
        {
            CadastroRespons cadResp = new CadastroRespons();
            cadResp.Show();
            this.Visible = false;             
            
        }
    }
}
