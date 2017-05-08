using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using BancoDeHoras.Models;
using BancoDeHoras.Uteis;

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
                SqlCommand creatTable = new SqlCommand("IF NOT EXISTS(SELECT * FROM sys.objects WHERE name = 'Funcionarios')" +
                                                          "CREATE TABLE Funcionarios " +
                                                          "(" +
                                                                "id_Func INT NOT NULL PRIMARY KEY IDENTITY(1, 1)," +
                                                                "fk_cnpj VARCHAR(14) NOT NULL," +
                                                                "CONSTRAINT Empresa_Funcionario FOREIGN KEY (fk_cnpj) REFERENCES Empresa(cnpj)," +
                                                                "cpf VARCHAR(14) NOT NULL," +
                                                                "nome VARCHAR(50) NOT NULL," +
                                                                "telefone VARCHAR(14) NOT NULL," +
                                                                "email VARCHAR(40) NOT NULL," +
                                                                "dt_Admissao DATE NOT NULL," +
                                                                "dt_Demissao DATE" +
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
                SqlCommand cadFuncionario = new SqlCommand("INSERT INTO Funcionarios(fk_cnpj, cpf, nome, telefone, email, dt_Admissao) " +
                                                                          " VALUES (@fk_cnpj, @cpf, @nome, @telefone, @email, @dt_Admissao)", conexao);
                cadFuncionario.Parameters.AddWithValue("@fk_cnpj", func.FK_CNPJ);
                cadFuncionario.Parameters.AddWithValue("@cpf", func.CPF);
                cadFuncionario.Parameters.AddWithValue("@nome", func.Nome);
                cadFuncionario.Parameters.AddWithValue("@telefone", func.Telefone);
                cadFuncionario.Parameters.AddWithValue("@email", func.Email);
                cadFuncionario.Parameters.AddWithValue("@dt_Admissao", func.Dt_Admissao);
                //cadFuncionario.Parameters.AddWithValue("@dt_Demissao", func.Dt_Demissao);


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

        //Verifica informações cadastrais.
        public FuncionarioModel consultaFunc(string cpf)
        {
            try
            {
                conexao = new SqlConnection(conexao_BD);
                SqlCommand selectFunc = new SqlCommand("SELECT * FROM Funcionarios WHERE cpf = @cpf", conexao);
                selectFunc.Parameters.AddWithValue("@cpf", cpf);
                conexao.Open();

                SqlDataReader leitor;

                FuncionarioModel funcModel = new FuncionarioModel();
                leitor = selectFunc.ExecuteReader(CommandBehavior.CloseConnection);

                while (leitor.Read())
                {
                    funcModel.ID = Convert.ToInt32(leitor["id_Func"]);
                    funcModel.Nome = leitor["nome"].ToString();
                    funcModel.CPF = leitor["cpf"].ToString();
                    funcModel.Email = leitor["email"].ToString();
                    funcModel.Telefone = leitor["telefone"].ToString();
                    funcModel.Dt_Admissao = Convert.ToDateTime(leitor["dt_Admissao"]);
                    string validaData = leitor["dt_Demissao"].ToString();
                    
                    if(string.IsNullOrEmpty(validaData))
                    {                        
                        funcModel.STR_dt_Demissao = null;
                    }
                    else
                    {
                        funcModel.STR_dt_Demissao = "Não está branco nem vazia" + validaData;
                        funcModel.Dt_Demissao = Convert.ToDateTime(leitor["dt_Demissao"]);
                    }                  
                }
                leitor.Close();

                return funcModel;

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
