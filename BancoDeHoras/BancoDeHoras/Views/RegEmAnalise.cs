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
using System.Collections;

namespace BancoDeHoras.Views
{
    public partial class RegEmAnalise : Form
    {
        EmpresaBLL empBLL = new EmpresaBLL();
        EmpresaModel empMod = new EmpresaModel();
        FuncionarioBLL funcBLL = new FuncionarioBLL();
        FuncionarioModel funcMod = new FuncionarioModel();
        RegistroBLL regBLL = new RegistroBLL();
        ArrayList registros = new ArrayList();           

        public RegEmAnalise()
        {
            InitializeComponent();

            empMod = empBLL.DadosEmpresaBLL();
            funcMod = funcBLL.ConsultaFuncByID(Login.id_user);

            tb_Nome_Emp.Text = empMod.Nome;
            tb_CNPJ.Text = empMod.CNPJ;
            tb_Nome.Text = funcMod.Nome;
            tb_CPF_Func.Text = funcMod.CPF;

            int index = funcMod.Nome.IndexOf(" ");
            string nomeCurto = funcMod.Nome.Substring(0, index);
            registros = regBLL.AnaliseReg(nomeCurto);
            try
            {                
                FuncionarioModel funcioMod = new FuncionarioModel();
                foreach (int fk_Id in registros)
                {
                    funcioMod = funcBLL.ConsultaFuncByID(fk_Id);                    
                    cb_Func_Reg.Items.Add(funcioMod.Nome);                    
                }

            }catch(Exception erro)
            {
                MessageBox.Show("" + erro.Message);
            }                    
        }

        private void cb_Func_Reg_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            RegistroModel regMod = new RegistroModel();
            foreach(int fk_Id in registros)
            {
                funcMod = funcBLL.ConsultaFuncByID(fk_Id);
                tb_CPF_Reg.Text = funcMod.CPF;
                if(funcMod.Nome == cb_Func_Reg.SelectedItem.ToString())
                {
                    
                    try
                    {
                        regMod = regBLL.infoRegistro(fk_Id);
                    }catch(Exception erro)
                    {
                        MessageBox.Show("Erro ao recuperar registro em análise. --- " + erro.Message);
                    }


                    tb_Data_Reg.Text = regMod.Data_Reg.ToString("ddMMyyyy").Replace("-", "/");
                    tb_Inicio_Reg.Text = regMod.Inicio_HE.ToString();
                    tb_Fim_Reg.Text = regMod.Fim_HE.ToString(); //3052017/16/05/2010
                    tb_Qtd_HE.Text = regMod.Qtd_Horas.ToString();
                    tb_Descricao_Reg.Text = regMod.Descricao;

                    
                }
            }
            MessageBox.Show("Testando busca de funcionario" + cb_Func_Reg.SelectedItem);
        }
    }
}
