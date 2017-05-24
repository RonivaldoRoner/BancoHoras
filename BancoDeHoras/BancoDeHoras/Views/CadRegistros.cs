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
using BancoDeHoras.Uteis;
using System.Collections;


namespace BancoDeHoras.Views
{
    public partial class CadRegistros : Form
    {
        ArrayList gerente = new ArrayList();
        EmpresaModel empMod = new EmpresaModel();
        EmpresaBLL empBLL = new EmpresaBLL();
        FuncionarioModel funcMod = new FuncionarioModel();
        FuncionarioBLL funcBLL = new FuncionarioBLL();
              
        public CadRegistros()
        {
            InitializeComponent();
            empMod = empBLL.DadosEmpresaBLL();
            funcMod = funcBLL.ConsultaFuncByID(Login.id_user);

            tb_Nome_Emp.Text = empMod.Nome;
            tb_CNPJ.Text = empMod.CNPJ;

            tb_Nome_Func.Text = funcMod.Nome;
            tb_CPF.Text = funcMod.CPF;

            try
            {                
                gerente = funcBLL.ALGerente();

                foreach (string nome in gerente)
                {
                    int index = nome.IndexOf(" ");
                    string nomeCurto = nome.Substring(0, index);
                    cb_Responsavel.Items.Add(nomeCurto);
                }
            }
            catch(Exception erro)
            {
                MessageBox.Show("Erro ao localizar resposáveis." + erro.Message);
            }       
        }

        private void CadRegistros_Load(object sender, EventArgs e) { }

        private void btn_Gravar_Click(object sender, EventArgs e)
        {
            RegistroBLL regBLL = new RegistroBLL();
            RegistroModel regMod = new RegistroModel();

            var inicio = Convert.ToDateTime(tb_Inicio_Reg.Text);
            var final = Convert.ToDateTime(tb_Fim_Reg.Text);
            TimeSpan diferenca = final.Subtract(inicio);
            TimeSpan qtd_HE = CalculaHE.CalcMinutos(diferenca);

            regMod.FK_Id_Func = funcMod.ID;
            regMod.Data_Reg = Convert.ToDateTime(tb_Data_Reg.Text);
            regMod.Inicio_HE = TimeSpan.Parse(tb_Inicio_Reg.Text);
            regMod.Fim_HE = TimeSpan.Parse(tb_Fim_Reg.Text);
            regMod.Qtd_Horas = qtd_HE;
            foreach (string nome in gerente)
            {
                int index = nome.IndexOf(" ");
                string nomeCurto = nome.Substring(0, index);
                if(nomeCurto == cb_Responsavel.Text)
                {
                    
                }                
            }

            regMod.Responsavel = cb_Responsavel.Text;
            regMod.Descricao = tb_Descricao_Reg.Text;

            try
            {
                regBLL.NovoRegistro(regMod);
                MessageBox.Show("Registro enviado para o Responsável.");
                this.Visible = false;

            }catch(Exception erro)
            {
                MessageBox.Show("Erro ao inserir novo Registro. -- " + erro.Message);
            }
            
            
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }       
        
    }
}
