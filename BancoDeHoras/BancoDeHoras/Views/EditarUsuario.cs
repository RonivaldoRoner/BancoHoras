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
        int id_Func;
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
            }
            userMod = userBLL.BuscaUsuario(Login.id_user);

            funcMod = funcBLL.consultaFuncBLL(Login.id_user);
            tb_CPF_Busca.Text = funcMod.CPF;
            tb_usuario.Text = userMod.Usuario;
            tb_senha.Text = Criptografia.Descriptografar(userMod.PW);            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cpf = tb_CPF_Busca.Text.Replace(",", "").Replace(".", "").Replace("-", "");
            funcMod = funcBLL.verificaFunc(cpf);
            if (string.IsNullOrEmpty(funcMod.STR_dt_Demissao))
            {
                id_Func = funcMod.ID;
            }else
            {
                MessageBox.Show("Funcionário inativo.");
            }                     
            

            if (string.IsNullOrEmpty(userMod.Usuario))
            {
                MessageBox.Show("Usuario não cadastrado. Favor gravar Usuário e senha para novo cadastro.");
            }else
            {
                try
                {
                    tb_usuario.Text = userMod.Usuario;
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Usuário não encontrado. --- " + erro.Message);
                }
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
                MessageBox.Show("Erro ao gravar alterações. --- " + erro);
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
