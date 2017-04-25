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

namespace BancoDeHoras.Views
{
    public partial class DadosRespons : Form
    {        
        public DadosRespons()
        {
            InitializeComponent();

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
