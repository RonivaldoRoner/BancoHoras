using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using BancoDeHoras.Models;

namespace BancoDeHoras.DAL
{
    class EmpresaDAL
    {
        EmpresaModel empModel = new EmpresaModel();
        private static string conexao_BD = @"Data Source =.\SQLEXPRESS; Initial Catalog = Teste; User id = sa; pwd=123456";
        SqlConnection conexao = null;


        public void creatDB()
        {

            //var usuario = "sa";
            //var senha = "123456";
            //conexao = new SqlConnection($@"Data Source =.\SQLEXPRESS; Initial Catalog = master; User id = {usuario}; pwd={senha}"); 
            conexao = new SqlConnection($@"Data Source =.\SQLEXPRESS; Initial Catalog = master; User id = sa; pwd=123456");


            SqlCommand creatDB = new SqlCommand("IF NOT EXISTS(SELECT * FROM sys.databases WHERE name ='Teste')CREATE DATABASE Teste", conexao);

            conexao.Open();
            creatDB.ExecuteNonQuery();
        }

        public void CreattableEmpresa()
        {
            
            try
            {
                conexao = new SqlConnection(conexao_BD);
                SqlCommand creatTable = new SqlCommand("IF NOT EXISTS(SELECT * FROM sys.objects WHERE name = 'Empresa')" +
                                                     "CREATE TABLE Empresa " +
                                                     "(" +
                                                        "cnpj VARCHAR(14) NOT NULL PRIMARY KEY," +
                                                        "nome VARCHAR(50)  NOT NULL," +
                                                        "endereco VARCHAR(50) NOT NULL," +
                                                        "numero INT NOT NULL," +
                                                        "end_comp VARCHAR(40)," +
                                                        "bairro VARCHAR(40) NOT NULL," +
                                                        "cidade VARCHAR(40) NOT NULL," +
                                                        "estado VARCHAR(2) NOT NULL," +
                                                        "cep VARCHAR(9) NOT NULL," +
                                                        "telefone VARCHAR(14) NOT NULL" +
                                                     ");", conexao);
                conexao.Open();
                creatTable.ExecuteNonQuery();
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
       
        public void cadEmpresa(EmpresaModel empresa)
        {
            try
            {
                conexao = new SqlConnection(conexao_BD);
                SqlCommand cadastEmpresa = new SqlCommand("INSERT INTO Empresa VALUES (@cnpj,@nome, @endereco, @numero, @end_comp, @bairro, @cidade, @estado, @cep, @telefone)", conexao);
                cadastEmpresa.Parameters.AddWithValue("@cnpj", empresa.CNPJ);
                cadastEmpresa.Parameters.AddWithValue("@nome", empresa.Nome);
                cadastEmpresa.Parameters.AddWithValue("@endereco", empresa.Endereco);
                cadastEmpresa.Parameters.AddWithValue("@numero", empresa.End_Num);
                cadastEmpresa.Parameters.AddWithValue("@end_comp", empresa.End_Comp);
                cadastEmpresa.Parameters.AddWithValue("@bairro", empresa.Bairro);
                cadastEmpresa.Parameters.AddWithValue("@cidade", empresa.Cidade);
                cadastEmpresa.Parameters.AddWithValue("@estado", empresa.Estado);
                cadastEmpresa.Parameters.AddWithValue("@cep", empresa.CEP);
                cadastEmpresa.Parameters.AddWithValue("@telefone", empresa.Telefone);
                              
                conexao.Open();
                cadastEmpresa.ExecuteNonQuery();             
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
                       
        public EmpresaModel DadosEmpresaDAL()
        {
            


            try
            {
                conexao = new SqlConnection(conexao_BD);
                SqlCommand selectEmpresa = new SqlCommand("SELECT * FROM Empresa", conexao);
                conexao.Open();


                SqlDataReader leitor;

                EmpresaModel empModel = new EmpresaModel();
                leitor = selectEmpresa.ExecuteReader(CommandBehavior.CloseConnection);

                while (leitor.Read())
                {
                    empModel.Nome = leitor["nome"].ToString();
                    empModel.CNPJ = leitor["cnpj"].ToString();
                    empModel.Telefone = leitor["telefone"].ToString();
                    empModel.Endereco = leitor["endereco"].ToString();
                    empModel.End_Num = Convert.ToInt32(leitor["numero"]);
                    empModel.End_Comp = leitor["end_comp"].ToString();
                    empModel.Bairro = leitor["bairro"].ToString();
                    empModel.Cidade = leitor["cidade"].ToString();
                    empModel.Estado = leitor["estado"].ToString();
                    empModel.CEP = leitor["cep"].ToString();
                }
                leitor.Close();
            
                return empModel;

            }   catch(Exception erro)
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
