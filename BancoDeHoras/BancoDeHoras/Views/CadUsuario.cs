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
            try
            {
                userBLL.CreatTableBLL();
                
            }catch(Exception erro)
            {
                MessageBox.Show("Erro ao criar tabela de usuários." + erro);
            }

        }

        private void btn_Gravar_Click(object sender, EventArgs e)
        {
            CadastroFunc cadFunc = new CadastroFunc();            
            FuncionarioBLL funcBLL = new FuncionarioBLL();
            FuncionarioModel funcMod = new FuncionarioModel();
            funcMod = funcBLL.verificaFunc(cpfFunc);

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
            }catch(Exception erro)
            {
                MessageBox.Show("Erro na criação de usuário." + erro);
            }


            this.Visible = false;
            
        }
    }
}
