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
            
            CadastroEmp cadEmp = new CadastroEmp();
            cadEmp.Show();
            this.Visible = false;
        }
    }
}
