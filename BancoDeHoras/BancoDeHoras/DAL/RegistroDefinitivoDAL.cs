﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BancoDeHoras.Models;
using System.Data.SqlClient;
using System.Data;

namespace BancoDeHoras.DAL
{
    class RegistroDefinitivoDAL
    {
        private static string conexao_BD = $@"Data Source = {Properties.Settings.Default.InstanciaSQLServer}; Initial Catalog = BancoDeHoras; User id = {Properties.Settings.Default.UserSQL}; pwd={Properties.Settings.Default.PWSQL}";

        SqlConnection conexao = null;

        public void CreateTableRegistro()
        {
            try
            {
                conexao = new SqlConnection(conexao_BD);
                SqlCommand createTable = new SqlCommand("IF NOT EXISTS(SELECT * FROM sys.objects WHERE name = 'RegDefinitivo')" +
                                                     "CREATE TABLE RegDefinitivo" +
                                                        "(" +
                                                        "id_Reg INT NOT NULL PRIMARY KEY IDENTITY(1, 1)," +
                                                        "fk_id_Func INT NOT NULL," +
                                                        "dt_Reg DATE NOT NULL," +
                                                        "CONSTRAINT RegDefinitivo_Funcionario FOREIGN KEY(fk_id_Func) REFERENCES Funcionarios(id_Func)," +
                                                        "tipo_Reg VARCHAR(20) NOT NULL," +
                                                        "inicio_HE TIME NOT NULL," +
                                                        "fim_HE TIME NOT NULL," +
                                                        "qtd_HE TIME NOT NULL," +
                                                        "responsavel VARCHAR(40) NOT NULL," +                                                        
                                                        "descricao VARCHAR(420) NOT NULL," +
                                                        "saldo_Dias int, " +
                                                        "saldo_Horas varchar(20) " +
                                                        ");", conexao);
                conexao.Open();
                createTable.ExecuteNonQuery();
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

        public void AddRegistro(RegistroModel regMod)
        {
            try
            {
                conexao = new SqlConnection(conexao_BD);
                SqlCommand inseriReg = new SqlCommand("INSERT INTO RegDefinitivo(fk_id_Func, dt_Reg, tipo_Reg, inicio_HE, fim_HE, qtd_HE, saldo_Dias, saldo_Horas, responsavel, descricao)" +
                                                                    "VALUES(@fk_id_Func, @dt_Reg, @tipo_Reg, @inicio_HE, @fim_HE, @qtd_HE, @saldo_Dias, @saldo_Horas, @responsavel, @descricao)", conexao);

                inseriReg.Parameters.AddWithValue("@fk_id_Func", regMod.FK_Id_Func);
                inseriReg.Parameters.AddWithValue("@dt_Reg", regMod.Data_Reg);
                inseriReg.Parameters.AddWithValue("@tipo_Reg", regMod.Tipo_Reg);
                inseriReg.Parameters.AddWithValue("@inicio_HE", regMod.Inicio_HE);
                inseriReg.Parameters.AddWithValue("@fim_HE", regMod.Fim_HE);
                inseriReg.Parameters.AddWithValue("@qtd_HE", regMod.Qtd_Horas);
                inseriReg.Parameters.AddWithValue("@responsavel", regMod.Responsavel);
                inseriReg.Parameters.AddWithValue("@saldo_Dias", regMod.Saldo_Dias);
                inseriReg.Parameters.AddWithValue("@saldo_Horas", regMod.Saldo_Horas);
                inseriReg.Parameters.AddWithValue("@descricao", regMod.Descricao);

                conexao.Open();
                inseriReg.ExecuteNonQuery();

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

        public RegistroModel InfoRegistro(int id)
        {

            try
            {
                conexao = new SqlConnection(conexao_BD);
                SqlCommand selectRegistros = new SqlCommand("SELECT * FROM RegDefinitivo WHERE fk_id_Func = @fk_id_Func", conexao);
                selectRegistros.Parameters.AddWithValue("@fk_id_Func", id);
                SqlDataReader leitor;
                conexao.Open();
                leitor = selectRegistros.ExecuteReader(CommandBehavior.CloseConnection);
                RegistroModel regMod = new RegistroModel();

                int i = 999999;

                while (leitor.Read())
                {
                    if (i > Convert.ToInt32(leitor["id_Reg"]))
                    {
                        regMod.Data_Reg = Convert.ToDateTime(leitor["dt_Reg"]);
                        regMod.Tipo_Reg = leitor["tipo_Reg"].ToString();
                        regMod.Inicio_HE = TimeSpan.Parse(leitor["inicio_HE"].ToString());
                        regMod.Fim_HE = TimeSpan.Parse(leitor["fim_HE"].ToString());
                        regMod.Qtd_Horas = TimeSpan.Parse(leitor["qtd_HE"].ToString());
                        regMod.Responsavel = leitor["responsavel"].ToString();
                        regMod.Descricao = leitor["descricao"].ToString();
                        regMod.Saldo_Dias = Convert.ToInt32(leitor["saldo_Dias"]);
                        regMod.Saldo_Horas = leitor["saldo_Horas"].ToString();
                        regMod.ID_Reg = Convert.ToInt32(leitor["id_Reg"]);
                        i = Convert.ToInt32(leitor["id_Reg"]);
                    }

                }

                return regMod;
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

        public RegistroModel UltimoRegistro(int id)
        {

            try
            {
                conexao = new SqlConnection(conexao_BD);
                SqlCommand selectRegistros = new SqlCommand("SELECT * FROM RegDefinitivo WHERE fk_id_Func = @fk_id_Func", conexao);
                selectRegistros.Parameters.AddWithValue("@fk_id_Func", id);
                SqlDataReader leitor;
                conexao.Open();
                leitor = selectRegistros.ExecuteReader(CommandBehavior.CloseConnection);
                RegistroModel regMod = new RegistroModel();

                int i = -1;

                while (leitor.Read())
                {
                    if (i < Convert.ToInt32(leitor["id_Reg"]))
                    {
                        regMod.Data_Reg = Convert.ToDateTime(leitor["dt_Reg"]);
                        regMod.Tipo_Reg = leitor["tipo_Reg"].ToString();
                        regMod.Inicio_HE = TimeSpan.Parse(leitor["inicio_HE"].ToString());
                        regMod.Fim_HE = TimeSpan.Parse(leitor["fim_HE"].ToString());
                        regMod.Qtd_Horas = TimeSpan.Parse(leitor["qtd_HE"].ToString());
                        regMod.Responsavel = leitor["responsavel"].ToString();
                        regMod.Descricao = leitor["descricao"].ToString();
                        regMod.Saldo_Horas = leitor["saldo_Horas"].ToString();
                        regMod.Saldo_Dias = Convert.ToInt32(leitor["saldo_Dias"]);
                        regMod.ID_Reg = Convert.ToInt32(leitor["id_Reg"]);
                        i = Convert.ToInt32(leitor["id_Reg"]);
                    }

                }

                return regMod;
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