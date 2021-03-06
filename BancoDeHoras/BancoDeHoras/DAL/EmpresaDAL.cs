﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using BancoDeHoras.Models;
using System.Configuration;


namespace BancoDeHoras.DAL
{
    class EmpresaDAL
    {     
        EmpresaModel empModel = new EmpresaModel();
        
        private static string conexao_BD_Master = $@"Data Source = {Properties.Settings.Default.InstanciaSQLServer}; Initial Catalog = master; User id = {Properties.Settings.Default.UserSQL}; pwd={Properties.Settings.Default.PWSQL}";
        private static string conexao_BD = $@"Data Source = {Properties.Settings.Default.InstanciaSQLServer}; Initial Catalog = BancoDeHoras; User id = {Properties.Settings.Default.UserSQL}; pwd={Properties.Settings.Default.PWSQL}";


        SqlConnection conexao = null;


        public void CreatDB()
        { 
            conexao = new SqlConnection(conexao_BD_Master);
            SqlCommand creatDB = new SqlCommand("IF NOT EXISTS(SELECT * FROM sys.databases WHERE name ='BancoDeHoras')CREATE DATABASE BancoDeHoras", conexao);
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
       
        public void CadEmpresa(EmpresaModel empresa)
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

        public void EditEmpresa(EmpresaModel empModel)
        {
            try
            {
                conexao = new SqlConnection(conexao_BD);
                SqlCommand editEmpresa = new SqlCommand("UPDATE Empresa SET " +
                                                        "nome = @nome, " +
                                                        "endereco = @endereco, " +
                                                        "numero = @numero, " +
                                                        "end_comp = @end_comp, " +
                                                        "bairro = @bairro, " +
                                                        "cidade = @cidade, " +
                                                        "estado = @estado, " +
                                                        "cep = @cep, " +
                                                        "telefone = @telefone " +
                                                        "WHERE cnpj = @cnpj ", conexao);
                editEmpresa.Parameters.AddWithValue("@nome", empModel.Nome);
                editEmpresa.Parameters.AddWithValue("@endereco", empModel.Endereco);
                editEmpresa.Parameters.AddWithValue("@numero", empModel.End_Num);
                editEmpresa.Parameters.AddWithValue("@end_comp", empModel.End_Comp);
                editEmpresa.Parameters.AddWithValue("@bairro", empModel.Bairro);
                editEmpresa.Parameters.AddWithValue("@cidade", empModel.Cidade);
                editEmpresa.Parameters.AddWithValue("@estado", empModel.Estado);
                editEmpresa.Parameters.AddWithValue("@cep", empModel.CEP);
                editEmpresa.Parameters.AddWithValue("@telefone", empModel.Telefone);
                editEmpresa.Parameters.AddWithValue("@cnpj", empModel.CNPJ);

                conexao.Open();
                editEmpresa.ExecuteNonQuery();
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
