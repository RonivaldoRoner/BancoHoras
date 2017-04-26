using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BancoDeHoras.Models;
using System.Data.SqlClient;
using System.Data;

namespace BancoDeHoras.DAL
{
    class ResponsavelDAL
    {
        private string conexao_BD = @"Data Source =.\SQLEXPRESS; Initial Catalog = Teste; User id = sa; pwd=123456";
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
                                                            "fk_cnpj VARCHAR(14) NOT NULL," +
                                                            "CONSTRAINT Responsavel_Empresa FOREIGN KEY (fk_cnpj) REFERENCES Empresa(cnpj)," +
                                                            "nome VARCHAR(50) NOT NULL," +
                                                            "cpf VARCHAR(11) NOT NULL," +
                                                            "telefone VARCHAR(14) NOT NULL," +
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

                SqlCommand cadResponsavel = new SqlCommand("INSERT INTO Responsavel VALUES (@fk_cnpj, @nome, @cpf, @telefone, @email)", conexao);
                cadResponsavel.Parameters.AddWithValue("@cpf", responsavel.CPF);
                cadResponsavel.Parameters.AddWithValue("@nome", responsavel.Nome_Resp);
                cadResponsavel.Parameters.AddWithValue("@email", responsavel.Email);
                cadResponsavel.Parameters.AddWithValue("@telefone", responsavel.Telefone);
                cadResponsavel.Parameters.AddWithValue("@fk_cnpj", responsavel.FK_CNPJ);

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

        public ResponsavelModel consultaResponsavel()
        {
            try
            {
                conexao = new SqlConnection(conexao_BD);

                SqlCommand consultaResponsavel = new SqlCommand("SELECT * FROM Responsavel", conexao);
                conexao.Open();

                SqlDataReader leitor;
                leitor = consultaResponsavel.ExecuteReader(CommandBehavior.CloseConnection);

                ResponsavelModel respModel = new ResponsavelModel();

                while (leitor.Read())
                {
                    respModel.Nome_Resp = leitor["nome"].ToString();
                    respModel.CPF = leitor["cpf"].ToString();
                    respModel.Email = leitor["email"].ToString();
                    respModel.Telefone = leitor["telefone"].ToString();
                }
                leitor.Close();

                return respModel;

            }catch(Exception erro)
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
