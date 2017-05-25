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
        RegistroModel regMod = new RegistroModel();

        int id_Registro;     

        public RegEmAnalise()
        {
            InitializeComponent();

            empMod = empBLL.DadosEmpresaBLL();
            funcMod = funcBLL.ConsultaFuncByID(Login.id_user);

            tb_Nome_Emp.Text = empMod.Nome;
            tb_CNPJ.Text = empMod.CNPJ;
            tb_Nome.Text = funcMod.Nome;
            tb_CPF_Func.Text = funcMod.CPF;

            try
            {
                int index = funcMod.Nome.IndexOf(" ");
                string nomeCurto = funcMod.Nome.Substring(0, index);
                registros = regBLL.AnaliseReg(nomeCurto);

                //FuncionarioModel funcioMod = new FuncionarioModel();
                foreach (int fk_Id in registros)
                {
                    funcMod = funcBLL.ConsultaFuncByID(fk_Id);
                    cb_Func_Reg.Items.Add(funcMod.Nome);
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("" + erro.Message);
            }

        }

        private void cb_Func_Reg_SelectedIndexChanged(object sender, EventArgs e)
        {                 
            foreach(int fk_Id in registros)
            {
                funcMod = funcBLL.ConsultaFuncByID(fk_Id);
                if(funcMod.Nome == cb_Func_Reg.SelectedItem.ToString())
                {                    
                    try
                    {
                        regMod = regBLL.infoRegistro(fk_Id);
                    }catch(Exception erro)
                    {
                        MessageBox.Show("Erro ao recuperar registro em análise. --- " + erro.Message);
                    }
                    tb_CPF_Reg.Text = funcMod.CPF;
                    tb_Data_Reg.Text = regMod.Data_Reg.ToString("ddMMyyyy").Replace("-", "/");
                    tb_Inicio_Reg.Text = regMod.Inicio_HE.ToString();
                    tb_Fim_Reg.Text = regMod.Fim_HE.ToString(); //3052017/16/05/2010
                    tb_Qtd_HE.Text = regMod.Qtd_Horas.ToString();
                    tb_Descricao_Reg.Text = regMod.Descricao;

                    id_Registro = regMod.ID_Reg;                    
                }
            }            
        }

        private void btn_Negar_Reg_Click(object sender, EventArgs e)
        {
            try
            {
                regBLL.DeleteReg(id_Registro);
                string itemSelecionado = cb_Func_Reg.SelectedItem.ToString();
                cb_Func_Reg.Items.Remove(itemSelecionado);
                if(cb_Func_Reg.Items.Count <= 0)
                {
                    this.Close();
                }
                cb_Func_Reg.SelectedIndex = -1;
            }catch(Exception erro)
            {
                MessageBox.Show("Erro ao excluir registro. -- " + erro.Message);
                this.Close();
            }            
        }

        private void btn_Confirmar_Click(object sender, EventArgs e)
        {

        }
    }
}
