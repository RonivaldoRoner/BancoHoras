using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using BancoDeHoras.Models;

namespace BancoDeHoras.DAL
{
    class UsuarioDAL
    {
        private string conexao_BD = @"Data Source =.\SQLEXPRESS; Initial Catalog = Teste; User id = sa; pwd=123456";

        SqlConnection conexao = null;

        public void CreatTableUsuarios()
        {
            try
            {
                conexao = new SqlConnection(conexao_BD);
                SqlCommand creatTable = new SqlCommand("IF NOT EXISTS(SELECT * FROM sys.objects WHERE name = 'Usuarios')" +
                                                          "CREATE TABLE Usuarios " +
                                                          "(" +
                                                                "id_User INT NOT NULL PRIMARY KEY IDENTITY(1, 1)," +
                                                                "fk_cpf VARCHAR(14) NOT NULL," +
                                                                "CONSTRAINT Funcionario_Usuario FOREIGN KEY (fk_cpf) REFERENCES Funcionarios(cpf)," +
                                                                "user VARCHAR(20) NOT NULL," +
                                                                "pw VARCHAR(50) NOT NULL," +
                                                                "tipo INT NOT NULL," +
                                                                "situacao VARCHAR(10)" +
                                                           ");", conexao); //45/2017/16/05/2008.
                conexao.Open();
                creatTable.ExecuteNonQuery();
            }
            catch (Exception erro)
            {
                throw erro;
            }
            finally
            {
                conexao.Close();
            }
        }

        public void criaUser(UsuarioModel userMod)
        {
            try
            {
                conexao = new SqlConnection(conexao_BD);

                SqlCommand insereUsuario = new SqlCommand("INSERT INTO Usuarios(fk_cpf, user, pw, tipo, situacao) " +
                                                                       "VALUES(@fk_cpf, @user, @pw, @tipo, @situacao)", conexao);

                insereUsuario.Parameters.AddWithValue("@fk_cpf", userMod.FK_CPF);
                insereUsuario.Parameters.AddWithValue("@user", userMod.Usuario);
                insereUsuario.Parameters.AddWithValue("@pw", userMod.PW);
                insereUsuario.Parameters.AddWithValue("@tipo", userMod.Tipo_Usuario);
                insereUsuario.Parameters.AddWithValue("@situacao", userMod.Situacao);

                conexao.Open();
                insereUsuario.ExecuteNonQuery();

            }catch(Exception erro)
            {
                throw erro;
            }
            finally
            {
                conexao.Close();
            }
        }

        public UsuarioModel buscaUser (string usuario, string senha)
        {
            try
            {
                conexao = new SqlConnection(conexao_BD);
                SqlCommand selectUser = new SqlCommand("SELECT * FROM Usuarios WHERE user = @user AND pw = @pw", conexao);
                selectUser.Parameters.AddWithValue("@user", usuario);
                selectUser.Parameters.AddWithValue("@pw", senha);

                SqlDataReader leitor;

                leitor = selectUser.ExecuteReader(CommandBehavior.CloseConnection);

                UsuarioModel userMod = new UsuarioModel();

                while (leitor.Read())
                {
                    userMod.FK_CPF = leitor["fk_cpf"].ToString();
                    userMod.Usuario = leitor["user"].ToString();
                    userMod.PW = leitor["pw"].ToString();
                    userMod.Tipo_Usuario = Convert.ToInt32(leitor["tipo"]);
                    userMod.Situacao = leitor["situacao"].ToString();
                }

                leitor.Close();
                return userMod;                

            }catch(Exception erro)
            {
                throw erro;
            }
            finally
            {
                conexao.Close();
            }
        }

        public void editUser(UsuarioModel modUser)
        {            
            try
            {
                conexao = new SqlConnection(conexao_BD);

                SqlCommand editUser = new SqlCommand("UPDATE Usuarios SET" +
                                                       "user = @user," +
                                                       "pw = @pw," +
                                                       "tipo = @tipo" +
                                                       "WHERE fk_cpf = @fk_cpf", conexao);

                conexao.Open();
                editUser.ExecuteNonQuery();
            }
            catch(Exception erro)
            {
                throw erro;
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
