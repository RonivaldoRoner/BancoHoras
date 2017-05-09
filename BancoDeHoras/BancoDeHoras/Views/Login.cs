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
        public static int id_user;
        public static string userSystem, pwSystem;
        string situacao = "Ativo";
        public Login()
        {
            InitializeComponent();
           
        }

        private void btn_logar_Click(object sender, EventArgs e)
        {            
            UsuarioModel userMod = new UsuarioModel();
            UsuarioBLL userBLL = new UsuarioBLL();
            if (rb_Admin_BD.Checked)
            {
                try
                {
                    tipo_usuario = 1;
                    userSystem = tb_usuario.Text;
                    pwSystem = tb_senha.Text;                    
                    EmpresaBLL empBLL = new EmpresaBLL();
                    empBLL.CreatDB(tb_usuario.Text, tb_senha.Text);                    
                    Principal principal = new Principal();
                    principal.Show();
                    this.Visible = false;
                }
                catch(Exception erro)
                {
                    MessageBox.Show("Usuário ou Senha de sistema inválido --- " + erro);
                }
            }else
            {
                string pwCripto = Criptografia.Criptografar(tb_senha.Text);
                try
                {
                    userMod = userBLL.DadosUsuario(tb_usuario.Text, pwCripto);

                    if ((tb_usuario.Text == userMod.Usuario) && (pwCripto == userMod.PW))
                    {
                        id_user = userMod.FK_ID_Func;
                        tipo_usuario = userMod.Tipo_Usuario;
                        if (userMod.Situacao == situacao)
                        {
                            MessageBox.Show("Login efetuado");
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
                

        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
