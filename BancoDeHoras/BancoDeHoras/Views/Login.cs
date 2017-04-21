﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BancoDeHoras.Views;

namespace BancoDeHoras
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_logar_Click(object sender, EventArgs e)
        {
            if((tb_usuario.TextLength > 0) && (tb_senha.TextLength > 0))
            {
                Administrador formAdmin = new Administrador();
                formAdmin.Show();
                this.Visible = false;
            }else
            {
                MessageBox.Show("Favor preencher os campos corretamente.");
            }
        }

        private void btn_Cadastrar_Empresa_Click(object sender, EventArgs e)
        {
            LoginAdmin formLoginAdmin = new LoginAdmin();
            formLoginAdmin.Show();
            this.Visible = false;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
