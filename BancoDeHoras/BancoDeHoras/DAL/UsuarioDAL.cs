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
        //private string conexao_BD = $@"Data Source =.\SQLEXPRESS; Initial Catalog = BancoDeHoras; User id = {Login.userSystem}; pwd={Login.pwSystem}";
        private static string conexao_BD = $@"Data Source = {Properties.Settings.Default.InstanciaSQLServer}; Initial Catalog = BancoDeHoras; User id = {Properties.Settings.Default.UserSQL}; pwd={Properties.Settings.Default.PWSQL}";

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
                                                                "fk_id_Func INT NOT NULL," +
                                                                "CONSTRAINT Funcionario_Usuario FOREIGN KEY (fk_id_Func) REFERENCES Funcionarios(id_Func)," +
                                                                "usuario VARCHAR(20) NOT NULL," +
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

        public void CriaUsuario(UsuarioModel userMod)
        {
            try
            {
                conexao = new SqlConnection(conexao_BD);

                SqlCommand insereUsuario = new SqlCommand("INSERT INTO Usuarios(fk_id_Func, usuario, pw, tipo, situacao) " +
                                                                       "VALUES(@fk_id_Func, @usuario, @pw, @tipo, @situacao)", conexao);

                insereUsuario.Parameters.AddWithValue("@fk_id_Func", userMod.FK_ID_Func);
                insereUsuario.Parameters.AddWithValue("@usuario", userMod.Usuario);
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

        public UsuarioModel ValidaUsuario(string usuario, string senha)
        {
            try
            {
                conexao = new SqlConnection(conexao_BD);
                SqlCommand selectUser = new SqlCommand("SELECT * FROM Usuarios WHERE usuario = @usuario AND pw = @pw", conexao);
                selectUser.Parameters.AddWithValue("@usuario", usuario);
                selectUser.Parameters.AddWithValue("@pw", senha);

                conexao.Open();

                SqlDataReader leitor;

                leitor = selectUser.ExecuteReader(CommandBehavior.CloseConnection);

                UsuarioModel userMod = new UsuarioModel();

                while (leitor.Read())
                {
                    userMod.FK_ID_Func = Convert.ToInt32(leitor["fk_id_Func"]);
                    userMod.Usuario = leitor["usuario"].ToString();
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

        public void EditaUsuario(UsuarioModel userMod)
        {            
            try
            {
                conexao = new SqlConnection(conexao_BD);

                SqlCommand editUser = new SqlCommand("UPDATE Usuarios SET " +
                                                       "usuario = @usuario, " +
                                                       "pw = @pw, " +
                                                       "tipo = @tipo, " +
                                                       "situacao = @situacao " +
                                                       "WHERE fk_id_Func = @fk_id_Func ", conexao);
                editUser.Parameters.AddWithValue("@fk_id_Func", userMod.FK_ID_Func);
                editUser.Parameters.AddWithValue("@usuario", userMod.Usuario);
                editUser.Parameters.AddWithValue("@pw", userMod.PW);
                editUser.Parameters.AddWithValue("@tipo", userMod.Tipo_Usuario);
                editUser.Parameters.AddWithValue("@situacao", userMod.Situacao);

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

        public UsuarioModel BuscaUsuario(int fk_id_Func)
        {
            try
            {
                conexao = new SqlConnection(conexao_BD);
                SqlCommand selectUser = new SqlCommand("SELECT * FROM Usuarios WHERE fk_id_Func = @fk_id_Func", conexao);
                selectUser.Parameters.AddWithValue("@fk_id_Func", fk_id_Func);
                

                conexao.Open();

                SqlDataReader leitor;

                leitor = selectUser.ExecuteReader(CommandBehavior.CloseConnection);

                UsuarioModel userMod = new UsuarioModel();

                while (leitor.Read())
                {
                    userMod.ID_User = Convert.ToInt32(leitor["id_User"]);
                    userMod.FK_ID_Func = Convert.ToInt32(leitor["fk_id_Func"]);
                    userMod.Usuario = leitor["usuario"].ToString();
                    userMod.PW = leitor["pw"].ToString();
                    userMod.Tipo_Usuario = Convert.ToInt32(leitor["tipo"]);
                    userMod.Situacao = leitor["situacao"].ToString();
                }

                leitor.Close();
                return userMod;

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
    }
}
