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
