using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using BancoDeHoras.Views;
using BancoDeHoras.BLL;


namespace BancoDeHoras
{
    public partial class Usuario : Form
    {
        // var senhaCript = Criptografia.Criptografar(tb_Senha.Text);

        //  var senhaDecript = Criptografia.Descriptografar(Criptografia.Criptografar(tb_Senha.Text));
        public Usuario()
        {
            InitializeComponent();            
        }
        private void Usuario_Load(object sender, EventArgs e)
        {

        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dirInstancia = new FolderBrowserDialog();
            //dirInstancia.ShowNewFolderButton = true;
            DialogResult dir = dirInstancia.ShowDialog();
            if(dir == DialogResult.OK)
            {
                tb_InstanciaSQL.Text = dirInstancia.SelectedPath;
            }else
            {
                MessageBox.Show("Selecione o diretorio da instancia SQL");
            }
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_usuario.Text)&&(string.IsNullOrEmpty(tb_senha.Text))&&(string.IsNullOrEmpty(tb_InstanciaSQL.Text)))
            {
                MessageBox.Show("Favor preencher todos os campos.");
            }else
            {
                try
                {
                    Properties.Settings.Default.InstanciaSQLServer = tb_InstanciaSQL.Text;
                    Properties.Settings.Default.UserSQL = tb_usuario.Text;
                    Properties.Settings.Default.PWSQL = tb_senha.Text;
                    Properties.Settings.Default.Save();

                    try
                    {
                        Principal principal = new Principal();
                        principal.Show();
                        this.Visible = false;

                        EmpresaBLL empBLL = new EmpresaBLL();
                        empBLL.CreatDB();
                        empBLL.CreatTbEmpresa();

                        ResponsavelBLL respBLL = new ResponsavelBLL();
                        respBLL.CreatTBbRespons();

                        FuncionarioBLL funcBLL = new FuncionarioBLL();
                        funcBLL.CreatTableFuncionarioBLL();

                        UsuarioBLL userBLL = new UsuarioBLL();
                        userBLL.CreatTableBLL();                        
                    }
                    catch(Exception erro)
                    {
                        MessageBox.Show("Erro na criação do BD e tabelas. ---" + erro);
                    }
                }
                catch(Exception erro)
                {
                    MessageBox.Show("Erro ao gravar informações. --- " + erro);
                }
               

                                                
            }            
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }              
    }
}
