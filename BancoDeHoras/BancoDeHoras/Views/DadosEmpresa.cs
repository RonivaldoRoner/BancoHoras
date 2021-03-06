﻿using System;
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

namespace BancoDeHoras.Views
{
    public partial class DadosEmpresa : Form
    {
       
        EmpresaBLL empBLL = new EmpresaBLL();
        EmpresaModel empMod = new EmpresaModel();

        
        public DadosEmpresa()
        {
            InitializeComponent();
            
            empMod = empBLL.DadosEmpresaBLL();

            if (string.IsNullOrEmpty(empMod.CNPJ))
            {

            }else
            {
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
                        
            if(Login.tipo_usuario != 1)
            {
                this.btn_Editar.Enabled = false;
                this.btn_Novo.Enabled = false;
            }

        }

        private void btn_Gravar_Click(object sender, EventArgs e)
        {
            empMod = empBLL.DadosEmpresaBLL();
            if (string.IsNullOrEmpty(empMod.CNPJ))
            {
                CadastroEmp cadEmp = new CadastroEmp();
                cadEmp.Show();
                this.Visible = false;
            }else
            {
                MessageBox.Show("Já existe empresa Cadastrada.");
            }
            
        }

        private void btn_Voltar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            EditEmpresa edtEmp = new EditEmpresa();
            edtEmp.Show();
            this.Visible = false;
        }
    }
}
