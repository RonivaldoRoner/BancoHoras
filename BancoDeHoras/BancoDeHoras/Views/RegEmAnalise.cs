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
using BancoDeHoras.Uteis;

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
        string itemSelecionado;


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
            foreach (int fk_Id in registros)
            {
                funcMod = funcBLL.ConsultaFuncByID(fk_Id);
                if (funcMod.Nome == cb_Func_Reg.SelectedItem.ToString())
                {
                    try
                    {
                        regMod = regBLL.infoRegistro(fk_Id);
                    }
                    catch (Exception erro)
                    {
                        MessageBox.Show("Erro ao recuperar registro em análise. --- " + erro.Message);
                    }
                    tb_CPF_Reg.Text = funcMod.CPF;
                    tb_Data_Reg.Text = regMod.Data_Reg.ToString("ddMMyyyy").Replace("-", "/");
                    tb_Inicio_Reg.Text = regMod.Inicio_HE.ToString();
                    tb_Fim_Reg.Text = regMod.Fim_HE.ToString(); //3052017/16/05/2010
                    tb_Qtd_HE.Text = regMod.Qtd_Horas.ToString();
                    tb_Descricao_Reg.Text = regMod.Descricao;
                    tb_Tipo_Registro.Text = regMod.Tipo_Reg;

                    id_Registro = regMod.ID_Reg;
                }
            }

        }

        private void btn_Negar_Reg_Click(object sender, EventArgs e)
        {
            try
            {
                regBLL.DeleteReg(id_Registro);                
                limpaCampos();
                if (cb_Func_Reg.Items.Count <= 0)
                {
                    this.Close();
                }               
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao excluir registro. -- " + erro.Message);
                this.Close();
            }
        }

        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            RegistroModel ultiRegistro = new RegistroModel();
            RegistroDefinitivoBLL regDefinBLL = new RegistroDefinitivoBLL();
            ultiRegistro = regDefinBLL.UltimoRegistroBLL(regMod.FK_Id_Func);
            TimeSpan difHoras = CalculaHE.CalcMinutos(TimeSpan.Parse(tb_Fim_Reg.Text).Subtract(TimeSpan.Parse(tb_Inicio_Reg.Text)));
            TimeSpan somaSaldoHrs;
            TimeSpan saldoAnt = TimeSpan.Parse(ultiRegistro.Saldo_Horas);

            if (ultiRegistro.ID_Reg > 0)
            {
                TimeSpan saldo = TimeSpan.Parse(ultiRegistro.Saldo_Horas);
                try
                {
                    try
                    {
                        TimeSpan horaDia = TimeSpan.Parse("23:59");
                        if (regMod.Tipo_Reg == "Hora Extra")
                        {
                            somaSaldoHrs = saldo.Add(difHoras);

                            if (somaSaldoHrs > horaDia)
                            {
                                regMod.Saldo_Horas = CalculaHE.Qtd_Horas_Superior_24(somaSaldoHrs, ultiRegistro.Saldo_Dias).Item2;
                                regMod.Saldo_Dias = CalculaHE.Qtd_Horas_Superior_24(somaSaldoHrs, ultiRegistro.Saldo_Dias).Item1;
                            }
                            else
                            {
                                regMod.Saldo_Horas = somaSaldoHrs.ToString();
                                regMod.Saldo_Dias = ultiRegistro.Saldo_Dias;
                            }
                        }
                        if (regMod.Tipo_Reg == "Compensaçao")
                        {
                            if (saldo < difHoras)
                            {
                                somaSaldoHrs = saldo.Subtract(difHoras);
                                regMod.Saldo_Horas = CalculaHE.Qtd_Horas_Inferior_24(somaSaldoHrs, ultiRegistro.Saldo_Dias).Item2;
                                regMod.Saldo_Dias = CalculaHE.Qtd_Horas_Inferior_24(somaSaldoHrs, ultiRegistro.Saldo_Dias).Item1;
                            }
                            else
                            {
                                somaSaldoHrs = saldo.Subtract(difHoras);
                                regMod.Saldo_Horas = saldoAnt.Subtract(difHoras).ToString();
                                regMod.Saldo_Dias = ultiRegistro.Saldo_Dias;
                            }
                        }

                    }
                    catch (Exception erro)
                    {
                        MessageBox.Show("Erro ao calculas horas" + erro.Message);
                    }

                    regDefinBLL.AddRegDefinitivo(regMod);
                    regBLL.DeleteReg(regMod.ID_Reg);
                    MessageBox.Show("Registro inserido com sucesso.");                    
                    limpaCampos();
                    if (cb_Func_Reg.Items.Count <= 0)
                    {
                        this.Close();
                    }
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Erro ao gravar dados na tabela de Registro. --- " + erro.Message);
                }
            }
            else
            {
                try
                {
                    regMod.Saldo_Horas = difHoras.ToString();
                    regDefinBLL.AddRegDefinitivo(regMod);
                    regBLL.DeleteReg(regMod.ID_Reg);
                    MessageBox.Show("Registro inserido com sucesso.");                    
                    limpaCampos();
                    if (cb_Func_Reg.Items.Count <= 0)
                    {
                        this.Close();
                    }
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Erro ao gravar registro no Banco de Dados. --- " + erro.Message);
                }
            }
        }

        private void limpaCampos()
        {
            try
            {
                tb_CPF_Reg.Text = "";
                tb_Data_Reg.Text = "";
                tb_Inicio_Reg.Text = "";
                tb_Fim_Reg.Text = ""; //3052017/16/05/2010
                tb_Qtd_HE.Text = "";
                tb_Descricao_Reg.Text = "";
                tb_Tipo_Registro.Text = "";
                itemSelecionado = cb_Func_Reg.SelectedItem.ToString();
                cb_Func_Reg.Items.Remove(itemSelecionado);
            }
            catch(Exception erro)
            {
                MessageBox.Show("Erro ao limpar campos. --- " + erro.Message);
            }
            
        }

    }
}