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
    class FuncionarioDAL
    {
        private string conexao_BD = @"Data Source =.\SQLEXPRESS; Initial Catalog = Teste; User id = sa; pwd=123456";
        
        SqlConnection conexao = null;

        public void CreatTableFuncionario()
        {
            try
            {
                conexao = new SqlConnection(conexao_BD);
                SqlCommand creatTable = new SqlCommand("IF NOT EXISTS(SELECT * FROM sys.objects WHERE name = 'Funcionario')" +
                                                          "CREATE TABLE Funcionario " +
                                                          "(" +
                                                                "id_Func INT NOT NULL PRIMARY KEY IDENTITY(1, 1),"+
                                                                "CPF VARCHAR(14) NOT NULL," +
                                                                "Nome VARCHAR(50) NOT NULL," +
                                                                "telefone VARCHAR(14) NOT NULL," +
                                                                "email VARCHAR(40) NOT NULL," +
                                                                "dt_Admissao DATETIME NOT NULL," +
                                                                "dt_Demissao DATETIME" +
                                                           ");", conexao); //19/04/2017/16/05/2008.
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

        public void AddUser(FuncionarioModel func)
        {            
            try
            {
                conexao = new SqlConnection(conexao_BD);
                SqlCommand cadFuncionario = new SqlCommand("INSERT INTO Funcionario VALUES (@cpf,@nome, @dt_Admissao, @dt_Demissao, @telefone)", conexao);
                cadFuncionario.Parameters.AddWithValue("@cpf", func.CPF );
                cadFuncionario.Parameters.AddWithValue("@nome", func.Nome);
                cadFuncionario.Parameters.AddWithValue("@dt_Admissao", func.Dt_Admissao);
                cadFuncionario.Parameters.AddWithValue("@dt_Demissao", func.Dt_Demissao);
                cadFuncionario.Parameters.AddWithValue("@telefone", func.Telefone);

            
                conexao.Open();
                cadFuncionario.ExecuteNonQuery();
                    
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
