using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
