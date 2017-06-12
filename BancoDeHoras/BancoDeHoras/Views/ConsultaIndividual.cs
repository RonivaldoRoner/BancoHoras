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
                       
            ConsultaIndividualBLL consultInd = new ConsultaIndividualBLL();
            ArrayList id_Registros = new ArrayList();
            RegistroModel regMod = new RegistroModel();

            try
            {
                id_Registros = consultInd.ConsultIdReg(Login.id_user);
                int cont = 0;
                int ant = 0;
                foreach (var id in id_Registros)
                {
                    try
                    {
                        regMod = consultInd.ConsultRegistros(Convert.ToInt32(id));

                    }
                    catch (Exception erro)
                    {
                        MessageBox.Show("Erro ao buscar registro." + erro.Message);
                    }

                    cont = Convert.ToInt32(id);
                    if(ant < cont)
                    {
                        ant = cont;
                        lb_TotalDias.Text = regMod.Saldo_Dias.ToString();
                        lb_TotalHoras.Text = Uteis.CalculaHE.FormataHora(TimeSpan.Parse(regMod.Saldo_Horas));
                    }                      
                    
                    ListViewItem lvi = new ListViewItem(regMod.Data_Reg.ToString("dd/MM/yyyy").Replace("-", "/"));
                    lvi.SubItems.Add(regMod.Tipo_Reg.ToString());
                    lvi.SubItems.Add(Uteis.CalculaHE.FormataHora(regMod.Qtd_Horas));
                    lvi.SubItems.Add(Uteis.CalculaHE.FormataHora(TimeSpan.Parse(regMod.Saldo_Horas)));
                    lvi.SubItems.Add(regMod.Saldo_Dias.ToString());
                    lvi.SubItems.Add("Detalhes");

                    lv_Cons_Individual.Items.Add(lvi);
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao carregar informações de registros." + erro);
            }            

        }

        private void btn_Filtra_Data_Click(object sender, EventArgs e)
        {

        }

        
    }
}
