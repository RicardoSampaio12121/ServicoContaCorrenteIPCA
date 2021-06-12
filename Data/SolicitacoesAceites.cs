using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace Data
{
    public static class SolicitacoesAceites
    {
        /// <summary>
        /// Insere na tabela
        /// </summary>
        /// <param name="cod_doc"></param>
        /// <param name="motivo"></param>
        /// <param name="valor"></param>
        public static void Insert(int cod_doc, string motivo, float valor)
        {
            using var con = new NpgsqlConnection("Host=localhost;Username=postgres;Password=2862;Database=IPCACC");
            con.Open();

            var sql = "INSERT INTO cc.accepted_solicitations (cod_docente, motivo, valor, data) VALUES (@cod_doc, @mot, @val, @date)";

            using var cmd = new NpgsqlCommand(sql, con);

            cmd.Parameters.AddWithValue("@cod_doc", cod_doc);
            cmd.Parameters.AddWithValue("@mot", motivo);
            cmd.Parameters.AddWithValue("@val", valor);
            cmd.Parameters.AddWithValue("@date", DateTime.Parse(DateTime.Now.ToShortDateString()));


            cmd.Prepare();
            cmd.ExecuteNonQuery();

            con.Close();
        }
    }
}
