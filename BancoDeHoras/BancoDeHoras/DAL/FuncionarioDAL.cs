
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using BancoDeHoras.Models;
using BancoDeHoras.Uteis;
using System.Collections;

namespace BancoDeHoras.DAL
{
    class FuncionarioDAL
    {

        //private string conexao_BD = $@"Data Source =.\SQLEXPRESS; Initial Catalog = BancoDeHoras; User id = {Login.userSystem}; pwd={Login.pwSystem}";
        private static string conexao_BD = $@"Data Source = {Properties.Settings.Default.InstanciaSQLServer}; Initial Catalog = BancoDeHoras; User id = {Properties.Settings.Default.UserSQL}; pwd={Properties.Settings.Default.PWSQL}";

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
                                                                "tipo INT NOT NULL," +
                                                                "nome VARCHAR(50) NOT NULL," +
                                                                "telefone VARCHAR(14) NOT NULL," +
                                                                "email VARCHAR(40) NOT NULL," +
                                                                "dt_Admissao DATE NOT NULL," +
                                                                "dt_Demissao DATE" +
                                                           ");", conexao); //19042017/16/05/2010.
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
                SqlCommand cadFuncionario = new SqlCommand("INSERT INTO Funcionarios(fk_cnpj, cpf, tipo, nome, telefone, email, dt_Admissao) " +
                                                                          " VALUES (@fk_cnpj, @cpf, @tipo, @nome, @telefone, @email, @dt_Admissao)", conexao);
                cadFuncionario.Parameters.AddWithValue("@fk_cnpj", func.FK_CNPJ);
                cadFuncionario.Parameters.AddWithValue("@cpf", func.CPF);
                cadFuncionario.Parameters.AddWithValue("@tipo", func.Tipo);
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

        public void EditFunc(FuncionarioModel funcMod)
        {
            try
            {
                if (string.IsNullOrEmpty(funcMod.STR_dt_Demissao))
                {
                    EditarFuncionario(funcMod);
                }
                else
                {
                    DemitirFuncionario(funcMod);
                }
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
        public FuncionarioModel VerificaFuncID(int id_Func)
        {
            try
            {
                conexao = new SqlConnection(conexao_BD);
                SqlCommand selectFunc = new SqlCommand("SELECT * FROM Funcionarios WHERE id_Func = @id_Func", conexao);
                selectFunc.Parameters.AddWithValue("@id_Func", id_Func);
                conexao.Open();

                SqlDataReader leitor;

                FuncionarioModel funcModel = new FuncionarioModel();
                leitor = selectFunc.ExecuteReader(CommandBehavior.CloseConnection);

                while (leitor.Read())
                {
                    funcModel.ID = Convert.ToInt32(leitor["id_Func"]);
                    funcModel.Nome = leitor["nome"].ToString();
                    funcModel.CPF = leitor["cpf"].ToString();
                    funcModel.Tipo = Convert.ToInt32(leitor["tipo"]);
                    funcModel.Email = leitor["email"].ToString();
                    funcModel.Telefone = leitor["telefone"].ToString();
                    funcModel.Dt_Admissao = Convert.ToDateTime(leitor["dt_Admissao"]);
                    string validaData = leitor["dt_Demissao"].ToString();

                    if (string.IsNullOrEmpty(validaData))
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

        public FuncionarioModel VerificaFuncCPF(string cpf)
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
                    funcModel.Tipo = Convert.ToInt32(leitor["tipo"]);
                    funcModel.Email = leitor["email"].ToString();
                    funcModel.Telefone = leitor["telefone"].ToString();
                    funcModel.Dt_Admissao = Convert.ToDateTime(leitor["dt_Admissao"]);
                    string validaData = leitor["dt_Demissao"].ToString();

                    if (string.IsNullOrEmpty(validaData))
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

        public FuncionarioModel VerificaFuncNome(string nome)
        {
            try
            {
                conexao = new SqlConnection(conexao_BD);
                SqlCommand selectFunc = new SqlCommand("SELECT * FROM Funcionarios WHERE nome LIKE @nome", conexao);
                selectFunc.Parameters.AddWithValue("@nome", nome);
                conexao.Open();

                SqlDataReader leitor;

                FuncionarioModel funcModel = new FuncionarioModel();
                leitor = selectFunc.ExecuteReader(CommandBehavior.CloseConnection);

                while (leitor.Read())
                {
                    funcModel.ID = Convert.ToInt32(leitor["id_Func"]);
                    funcModel.Nome = leitor["nome"].ToString();
                    funcModel.CPF = leitor["cpf"].ToString();
                    funcModel.Tipo = Convert.ToInt32(leitor["tipo"]);
                    funcModel.Email = leitor["email"].ToString();
                    funcModel.Telefone = leitor["telefone"].ToString();
                    funcModel.Dt_Admissao = Convert.ToDateTime(leitor["dt_Admissao"]);
                    string validaData = leitor["dt_Demissao"].ToString();

                    if (string.IsNullOrEmpty(validaData))
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

        public ArrayList ArrayList()
        {

            conexao = new SqlConnection(conexao_BD);
            SqlCommand selectGer = new SqlCommand("SELECT * FROM Funcionarios WHERE tipo = 1", conexao);
            SqlDataReader leitor;
            conexao.Open();
            leitor = selectGer.ExecuteReader(CommandBehavior.CloseConnection);
            ArrayList gerente = new ArrayList();

            try
            {
                while (leitor.Read())
                {
                    gerente.Add(leitor["nome"].ToString());
                }

                return gerente;
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

        public ArrayList ListaFuncionarios()
        {
            conexao = new SqlConnection(conexao_BD);
            SqlCommand selectGer = new SqlCommand("SELECT nome FROM Funcionarios", conexao);
            SqlDataReader leitor;
            conexao.Open();
            leitor = selectGer.ExecuteReader(CommandBehavior.CloseConnection);
            ArrayList gerente = new ArrayList();

            try
            {
                while (leitor.Read())
                {
                    gerente.Add(leitor["nome"].ToString());
                }

                return gerente;
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

        private void EditarFuncionario(FuncionarioModel funcMod)
        {
            try
            {
                conexao = new SqlConnection(conexao_BD);
                SqlCommand editFunc = new SqlCommand("UPDATE Funcionarios SET " +
                                                        "cpf = @cpf, " +
                                                        "tipo = @tipo, " +
                                                        "nome = @nome, " +
                                                        "telefone = @telefone, " +
                                                        "email = @email, " +
                                                        "dt_Admissao = @dt_Admissao " +
                                                        "WHERE id_Func = @id_Func", conexao);
                editFunc.Parameters.AddWithValue("@id_Func", funcMod.ID);
                editFunc.Parameters.AddWithValue("@cpf", funcMod.CPF);
                editFunc.Parameters.AddWithValue("@tipo", funcMod.Tipo);
                editFunc.Parameters.AddWithValue("@nome", funcMod.Nome);
                editFunc.Parameters.AddWithValue("@telefone", funcMod.Telefone);
                editFunc.Parameters.AddWithValue("@email", funcMod.Email);
                editFunc.Parameters.AddWithValue("@dt_Admissao", funcMod.Dt_Admissao);

                conexao.Open();
                editFunc.ExecuteNonQuery();
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        private void DemitirFuncionario(FuncionarioModel funcMod)
        {
            try
            {
                conexao = new SqlConnection(conexao_BD);
                SqlCommand editFuncDemitido = new SqlCommand("UPDATE Funcionarios SET " +
                                                    "cpf = @cpf, " +
                                                    "tipo = @tipo, " +
                                                    "nome = @nome, " +
                                                    "telefone = @telefone, " +
                                                    "email = @email, " +
                                                    "dt_Admissao = @dt_Admissao, " +
                                                    "dt_Demissao = @dt_Demissao " +
                                                    "WHERE id_Func = @id_Func", conexao);

                editFuncDemitido.Parameters.AddWithValue("@id_Func", funcMod.ID);
                editFuncDemitido.Parameters.AddWithValue("@cpf", funcMod.CPF);
                editFuncDemitido.Parameters.AddWithValue("@tipo", funcMod.Tipo);
                editFuncDemitido.Parameters.AddWithValue("@nome", funcMod.Nome);
                editFuncDemitido.Parameters.AddWithValue("@telefone", funcMod.Telefone);
                editFuncDemitido.Parameters.AddWithValue("@email", funcMod.Email);
                editFuncDemitido.Parameters.AddWithValue("@dt_Admissao", funcMod.Dt_Admissao);
                editFuncDemitido.Parameters.AddWithValue("@dt_Demissao", funcMod.Dt_Demissao);


                conexao.Open();
                editFuncDemitido.ExecuteNonQuery();
            }
            catch (Exception erro)
            {
                throw erro;
            }

        }
    }
}

