﻿using System;
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
    public partial class EditEmpresa : Form
    {
        public EditEmpresa()
        {
            InitializeComponent();

            EmpresaBLL empBLL = new EmpresaBLL();
            EmpresaModel empMod = new EmpresaModel();

            empMod = empBLL.DadosEmpresaBLL();

            tb_Nome_Emp.Text = empMod.Nome;
            tb_CNPJ.Text = empMod.CNPJ;
            tb_Endereco.Text = empMod.Endereco;
            tb_Num.Text = empMod.End_Num.ToString();
            tb_Complem.Text = empMod.End_Comp;
            tb_Bairro.Text = empMod.Bairro;
            tb_Cidade.Text = empMod.Cidade;
            tb_UF.Text = empMod.Estado;
            tb_CEP.Text = empMod.CEP;
            tb_Telefone.Text = empMod.Telefone.Replace(" ", "");
        }

        private void btn_Gravar_Click(object sender, EventArgs e)
        {
            
            EmpresaModel empModel = new EmpresaModel();
            empModel.CNPJ = tb_CNPJ.Text.Replace(".", "").Replace("/", "").Replace("-", "").Replace(",", "");
            empModel.Nome = tb_Nome_Emp.Text;
            empModel.Endereco = tb_Endereco.Text;
            empModel.End_Num = Convert.ToInt32(tb_Num.Text);
            empModel.End_Comp = tb_Complem.Text;
            empModel.Bairro = tb_Bairro.Text;
            empModel.Cidade = tb_Cidade.Text;
            empModel.Estado = tb_UF.Text;
            empModel.CEP = tb_CEP.Text.Replace("-", "");
            empModel.Telefone = tb_Telefone.Text.Replace("(", "").Replace(")", "").Replace("-", "");

            try
            {
                EmpresaBLL empBLL = new EmpresaBLL();
                empBLL.editEmpresaBLL(empModel);
            }catch(Exception erro)
            {
                MessageBox.Show("Erro na edição de dados." + erro);
            }
            DadosEmpresa dadosEmp = new DadosEmpresa();
            dadosEmp.Show();
            this.Visible = false;

        }

        private void btn_Voltar_Click(object sender, EventArgs e)
        {
            DadosEmpresa dadosEmp = new DadosEmpresa();
            dadosEmp.Show();
            this.Visible = false;
        }
    }
}
