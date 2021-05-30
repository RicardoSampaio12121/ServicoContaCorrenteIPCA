using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Connector;
using Npgsql;

namespace Data
{
    public static class RequestCreditsArticle
    {
        public static void InsertRequest(int cod, string art, string rev)
        {
            //NpgsqlConnection connection = Connector.Connector.OpenConnection();

            using var con = new NpgsqlConnection("Host=localhost;Username=postgres;Password=2862;Database=IPCACC");
            con.Open();

            var sql = "INSERT INTO cc.pedido_credito_artigo (cod_docente, artigo, revista, request_date) VALUES (@cod_doc, @art, @Rev, @rd)";

            using var cmd = new NpgsqlCommand(sql, con);

            cmd.Parameters.AddWithValue("@cod_doc", cod);
            cmd.Parameters.AddWithValue("@art", art);
            cmd.Parameters.AddWithValue("@Rev", rev);
            cmd.Parameters.AddWithValue("@rd", DateTime.Now);

            cmd.Prepare();
            cmd.ExecuteNonQuery();

           Connector.Connector.CloseConnection(con);
        }

        public static DataTable Get()
        {
            var output = new DataTable();

            using var con = new NpgsqlConnection("Host=localhost;Username=postgres;Password=2862;Database=IPCACC");
            var sql = "SELECT * FROM cc.pedido_credito_artigo";

            using var cmd = new NpgsqlCommand(sql, con);
            using var da = new NpgsqlDataAdapter(cmd);
            da.Fill(output);
            return output;
        }

        public static DataTable GetByCodTeacher(int cod)
        {
            var output = new DataTable();

            using var con = new NpgsqlConnection("Host=localhost;Username=postgres;Password=2862;Database=IPCACC");
            var sql = $"SELECT * FROM cc.pedido_credito_artigo WHERE cod_docente = {cod}";

            using var cmd = new NpgsqlCommand(sql, con);
            using var da = new NpgsqlDataAdapter(cmd);
            da.Fill(output);
            return output;
        }

        public static void Delete(int cod)
        {
            using var con = new NpgsqlConnection("Host=localhost;Username=postgres;Password=2862;Database=IPCACC");
            var sql = $"DELETE FROM cc.pedido_credito_artigo WHERE cod_pedido = {cod}";
            con.Open();
            using var cmd = new NpgsqlCommand(sql, con);
            cmd.Prepare();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
