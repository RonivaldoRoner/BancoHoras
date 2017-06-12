using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BancoDeHoras.Models;

namespace BancoDeHoras.DAL
{
    class ConsultasDAL
    {
        private static string conexao_BD = $@"Data Source = {Properties.Settings.Default.InstanciaSQLServer}; Initial Catalog = BancoDeHoras; User id = {Properties.Settings.Default.UserSQL}; pwd={Properties.Settings.Default.PWSQL}";
        SqlConnection conexao = null;

        public ListView Cons_Individual(int id_User)
        {
            ListView registros = new ListView();                               

            try
            {
                conexao = new SqlConnection(conexao_BD);
                SqlCommand scan_Reg = new SqlCommand("SELECT * FROM RegDefinitivo WHERE fk_id_Func = @fk_id_Func;", conexao);
                scan_Reg.Parameters.AddWithValue("@fk_id_Func", id_User);

                SqlDataReader leitor;
                conexao.Open();

                leitor = scan_Reg.ExecuteReader(CommandBehavior.CloseConnection);
                DateTime data_Reg;

                while (leitor.Read())
                {
                    data_Reg = Convert.ToDateTime(leitor["dt_Reg"]);
                    ListViewItem lvi = new ListViewItem(data_Reg.ToString("ddMMyyyy").Replace("-", "/"));
                    lvi.SubItems.Add(leitor["tipo_Reg"].ToString());
                    lvi.SubItems.Add(leitor["qtd_HE"].ToString());
                    lvi.SubItems.Add(leitor["saldo_Horas"].ToString());
                    lvi.SubItems.Add(leitor["saldo_Dias"].ToString());
                    lvi.SubItems.Add(leitor["id_Reg"].ToString());                    

                    registros.Items.Add(lvi);
                }
                return registros;
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

        public ArrayList Consult_Id_Registros(int id)
        {
            try
            {
                conexao = new SqlConnection(conexao_BD);
                SqlCommand selectIdRegistros = new SqlCommand("SELECT id_Reg FROM RegDefinitivo WHERE fk_id_Func LIKE @fk_id_Func ORDER BY id_Reg DESC;", conexao);
                selectIdRegistros.Parameters.AddWithValue("@fk_id_Func", id);

                SqlDataReader leitor;
                conexao.Open();

                leitor = selectIdRegistros.ExecuteReader(CommandBehavior.CloseConnection);
                ArrayList listaIdReg = new ArrayList();

                while (leitor.Read())
                {
                    listaIdReg.Add(leitor["id_Reg"].ToString());
                }

                return listaIdReg;
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

        public RegistroModel Consult_Registro(int id_Reg)
        {
            try
            {
                conexao = new SqlConnection(conexao_BD);
                SqlCommand selectRegistro = new SqlCommand("SELECT * FROM RegDefinitivo WHERE id_Reg like @id_Reg;", conexao);
                selectRegistro.Parameters.AddWithValue("@id_Reg", id_Reg);

                SqlDataReader leitor;
                conexao.Open();

                leitor = selectRegistro.ExecuteReader(CommandBehavior.CloseConnection);
                RegistroModel regMod = new RegistroModel();

                while (leitor.Read())
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

                }

                return regMod;

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
