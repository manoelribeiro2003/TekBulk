using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoTecBulk
{
    internal class Banco
    {
        private static SQLiteConnection conexao;
        public static SQLiteConnection ConexaoBanco()
        {
            conexao = new SQLiteConnection("Data Source = ..\\..\\..\\Banco\\patriBanco.db");
            conexao.Open();
            return conexao;
        }

        public static DataTable consulta(string sql)
        {
            SQLiteDataAdapter da;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = ConexaoBanco().CreateCommand())
                {
                    cmd.CommandText = sql;
                    da = new SQLiteDataAdapter(cmd.CommandText, ConexaoBanco());
                    da.Fill(dt);
                    ConexaoBanco().Close();
                    return dt;
                }
            }
            catch (Exception ex)
            {
                ConexaoBanco().Close();
                throw ex;
            }

        }
    }
}
