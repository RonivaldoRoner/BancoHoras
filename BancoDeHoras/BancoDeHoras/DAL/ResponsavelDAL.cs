using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BancoDeHoras.Models;
using System.Data.SqlClient;

namespace BancoDeHoras.DAL
{
    class ResponsavelDAL
    {
        private string conexao_BD = @"Data Source =.\SQLEXPRESS; Initial Catalog = BancoHoras; User id = sa; pwd=123456";
        SqlConnection conexao = null;

        public void CreatTableResponsavel()
        {
            try
            {
                conexao = new SqlConnection(conexao_BD);
                SqlCommand creatTable = new SqlCommand("IF NOT EXISTS(SELECT * FROM sys.objects WHERE name = 'Responsavel')" +
                                                      "CREATE TABLE Responsavel " +
                                                      "(" +
                                                            "id_Resp INT NOT NULL  PRIMARY KEY IDENTITY(1, 1)," +
                                                            "nome VARCHAR(50) NOT NULL," +
                                                            "cpf VARCHAR(11) NOT NULL," +
                                                            "email VARCHAR(50) NOT NULL" +
                                                       ");", conexao);
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

        public void cadResponsavel(ResponsavelModel responsavel)
        {
            try
            {
                conexao = new SqlConnection(conexao_BD);

                SqlCommand cadResponsavel = new SqlCommand("INSERT INTO Responsavel VALUES (@cpf, @nome, @email)", conexao);
                cadResponsavel.Parameters.AddWithValue("@cpf", responsavel.CPF);
                cadResponsavel.Parameters.AddWithValue("@nome", responsavel.Nome_Resp);
                cadResponsavel.Parameters.AddWithValue("@email", responsavel.Email);

                conexao.Open();

                cadResponsavel.ExecuteNonQuery();

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
