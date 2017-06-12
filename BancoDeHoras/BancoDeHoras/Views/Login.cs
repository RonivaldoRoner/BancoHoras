using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BancoDeHoras.Views;
using BancoDeHoras.Models;
using BancoDeHoras.BLL;
using BancoDeHoras.Uteis;

namespace BancoDeHoras
{
    public partial class Login : Form
    {
        public static int tipo_usuario;
        public static int id_user; //ID Usuario que é igual ao FK_ID_User da tabela Usuarios.      
        string situacao = "Ativo";
        public Login()
        {
            InitializeComponent();
        }
        
        private void btn_logar_Click(object sender, EventArgs e)
        {            
            UsuarioModel userMod = new UsuarioModel();
            UsuarioBLL userBLL = new UsuarioBLL();
            string Administrador = "Administrador";
            string senha = "rrmbancodehoras";
            

            if (rb_Admin_BD.Checked)
            {
                if((tb_usuario.Text == Administrador)&&(tb_senha.Text == senha))
                {
                    tipo_usuario = 1;
                    Usuario userDB = new Usuario();
                    userDB.Show();
                    this.Visible = false;
                }else
                {
                    MessageBox.Show("Usuario ou senha incorretos.");
                }            
            }else
            {
                string pwCripto = Criptografia.Criptografar(tb_senha.Text);
                if((tb_usuario.Text == Administrador)&&(tb_senha.Text == senha))
                {
                    Principal principal = new Principal();
                    tipo_usuario = 1;
                    principal.Show();
                    this.Visible = false;
                }else
                {
                    try
                    {
                        userMod = userBLL.DadosUsuario(tb_usuario.Text, pwCripto);

                        if ((tb_usuario.Text == userMod.Usuario) && (pwCripto == userMod.PW))
                        {
                            id_user = userMod.FK_ID_Func;
                            tipo_usuario = userMod.Tipo_Usuario;
                            
                            if (userMod.Situacao == situacao)
                            {
                                //MessageBox.Show("Login efetuado");
                                Principal principal = new Principal();
                                principal.Show();

                                this.Visible = false;
                            }
                            else
                            {
                                MessageBox.Show("Usuário desativado.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Usuário ou senha invalido.");
                        }
                    }
                    catch (Exception erro)
                    {
                        MessageBox.Show("Erro ao buscar Usuário e Senha." + erro);
                    }
                }               
            }          
        }               

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
