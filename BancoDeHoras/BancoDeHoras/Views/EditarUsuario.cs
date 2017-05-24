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
using BancoDeHoras.Models;

namespace BancoDeHoras.Views
{
    public partial class EditarUsuario : Form
    {       
        
        FuncionarioModel funcMod = new FuncionarioModel();
        UsuarioModel userMod = new UsuarioModel();
        FuncionarioBLL funcBLL = new FuncionarioBLL();
        UsuarioBLL userBLL = new UsuarioBLL();

        public EditarUsuario()
        {
            InitializeComponent();
            if(Login.tipo_usuario != 1)
            {
                rb_Gerente.Enabled = false;
                tb_CPF_Busca.Enabled = false;
                btn_Novo_Usuario.Enabled = false;
                btn_LocalizaUsuario.Enabled = false;
            }
            userMod = userBLL.BuscaUsuario(Login.id_user);

            funcMod = funcBLL.ConsultaFuncByID(Login.id_user);
            tb_CPF_Busca.Text = funcMod.CPF;
            tb_usuario.Text = userMod.Usuario;
            tb_senha.Text = Criptografia.Descriptografar(userMod.PW);
            if(Login.tipo_usuario != 1)
            {
                tb_CPF_Busca.Enabled = false;
            }                  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cpf = tb_CPF_Busca.Text.Replace(",", "").Replace(".", "").Replace("-", "");
            funcMod = funcBLL.ConsultaFuncByCPF(cpf);

            if (string.IsNullOrEmpty(funcMod.STR_dt_Demissao))
            {               
                try
                {
                    userMod = userBLL.BuscaUsuario(funcMod.ID);
                    if (string.IsNullOrEmpty(userMod.Usuario))
                    {
                        MessageBox.Show("Usuário não cadastrado.");
                    }else
                    {
                        tb_usuario.Text = userMod.Usuario;
                        tb_senha.Text = Criptografia.Descriptografar(userMod.PW);
                    }
                }catch(Exception erro)
                {
                    MessageBox.Show("" + erro.Message);
                }
                this.btn_Gravar.Enabled = false;

            }
            else
            {
                MessageBox.Show("Funcionário demitido.");
                btn_Gravar.Enabled = false;
            }                                                
        }

        private void btn_Gravar_Click(object sender, EventArgs e)
        {
            userMod.Usuario = tb_usuario.Text;
            userMod.PW = Criptografia.Criptografar(tb_senha.Text);
            try
            {
                userBLL.EditaUsuario(userMod);
                MessageBox.Show("Alteração salva com sucesso.");
                this.Visible = false;
            }catch(Exception erro)
            {
                MessageBox.Show("Erro ao gravar alterações. --- " + erro.Message);
            }
        }

        private void btn_Novo_Usuario_Click(object sender, EventArgs e)
        {
            CadUsuario cadUser = new CadUsuario(funcMod.CPF);
            cadUser.Show();
            this.Visible = false;
        }
    }
}
