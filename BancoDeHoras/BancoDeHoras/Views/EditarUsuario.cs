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

namespace BancoDeHoras.Views
{
    public partial class EditarUsuario : Form
    {
        public EditarUsuario()
        {
            InitializeComponent();
        }

        private void btn_Gravar_Click(object sender, EventArgs e)
        {
            try
            {
                UsuarioBLL userBll = new UsuarioBLL();
                string senhaCrip = Criptografia.Criptografar(tb_senha.Text);
                userBll.CreatUserSstem(tb_usuario.Text, senhaCrip);

            }catch(Exception erro)
            {
                MessageBox.Show("Erro ao criar usuario de sistema." + erro);
            }

        }
    }
}
