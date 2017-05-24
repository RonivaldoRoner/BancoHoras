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
using BancoDeHoras.Models;
using BancoDeHoras.Uteis;

namespace BancoDeHoras.Views
{
   
    public partial class CadUsuario : Form
    {
        UsuarioBLL userBLL = new UsuarioBLL();
        UsuarioModel userMod = new UsuarioModel();
        string cpfFunc;

        public CadUsuario(string cpf)
        {
            InitializeComponent();
            cpfFunc = cpf;
            tb_CPF.Text = cpf;
            if(Login.tipo_usuario != 1)
            {
                tb_CPF.Enabled = false;
            }
            MessageBox.Show("Favor cadastrar usuário e senha para acesso do funcionário.");               
        }

        private void btn_Gravar_Click(object sender, EventArgs e)
        {
            CadastroFunc cadFunc = new CadastroFunc();            
            FuncionarioBLL funcBLL = new FuncionarioBLL();
            FuncionarioModel funcMod = new FuncionarioModel();
            funcMod = funcBLL.ConsultaFuncByCPF(cpfFunc);

            UsuarioModel userMod = new UsuarioModel();
            userMod.FK_ID_Func = funcMod.ID;
            userMod.Usuario = tb_usuario.Text;
            string senhaCrip = Criptografia.Criptografar(tb_senha.Text);
            userMod.PW = senhaCrip;

            if (rb_Gerente.Checked)
            {
                //Quando tipo_Usuario == 1, é um usuario administrador.
                userMod.Tipo_Usuario = 1;
            }else
            {
                //Quando tipo_Usuario == 2, é um usuario simples.
                userMod.Tipo_Usuario = 2;
            }
            userMod.Situacao = "Ativo";

            try
            {
                userBLL.CadUser(userMod);
                MessageBox.Show("Usuário gravado com sucesso.");
            }catch(Exception erro)
            {
                MessageBox.Show("Erro ao gravar usuário. --- " + erro.Message);
            }                       
            this.Visible = false;
            cadFunc.Visible = false;           
        }

        private void btn_Voltar_Click(object sender, EventArgs e)
        {            
            this.Visible = false;
        }
    }
}
