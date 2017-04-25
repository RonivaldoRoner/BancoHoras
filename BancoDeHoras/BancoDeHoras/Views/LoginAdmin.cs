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
using BancoDeHoras.Uteis;
using BancoDeHoras.Views;
using BancoDeHoras.Models;

namespace BancoDeHoras.Views
{
    public partial class LoginAdmin : Form
    {
        public LoginAdmin()
        {
            InitializeComponent();
        }

        private void btn_Logar_Adm_Click(object sender, EventArgs e)
        {
            string user = tb_Admin_DB.Text;
            string senha = tb_Senha_AdminDB.Text;

            ValidarUsuario vdUser = new ValidarUsuario();
            if(!vdUser.validUser(user, senha))
            {
                MessageBox.Show("Usuario ou senha inválidos.");
                 
            }else
            {
                validUser();
                                              
            }
            
                                     
                   
            
        }

        public Boolean validUser()
        {
            return true;
        }
                

    }
}
