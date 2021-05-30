using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace Data
{
    public static class PublishedArticles
    {
        public static void Insert(int cod, string art, string rev, DateTime dt)
        {
            using var con = new NpgsqlConnection("Host=localhost;Username=postgres;Password=2862;Database=IPCACC");
            con.Open();

            var sql = "INSERT INTO cc.artigos_publicados (cod_docente, artigo, revista, date) VALUES (@cod_doc, @art, @Rev, @dt)";

            using var cmd = new NpgsqlCommand(sql, con);

            cmd.Parameters.AddWithValue("@cod_doc", cod);
            cmd.Parameters.AddWithValue("@art", art);
            cmd.Parameters.AddWithValue("@Rev", rev);
            cmd.Parameters.AddWithValue("@dt", dt);

            cmd.Prepare();
            cmd.ExecuteNonQuery();

            Connector.Connector.CloseConnection(con);
        }
    }
}
