using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace Data
{
    public class RequestCreditsHours
    {
        public static void InsertRequest(int cod, DateTime date, float hours)
        {
            using var con = new NpgsqlConnection("Host=localhost;Username=postgres;Password=2862;Database=IPCACC");
            con.Open();

            var sql = "INSERT INTO cc.pedido_credito_horas (cod_docente, date, hours, request_date) VALUES (@cod_doc, @date, @hours, @rd)";

            using var cmd = new NpgsqlCommand(sql, con);

            cmd.Parameters.AddWithValue("@cod_doc", cod);
            cmd.Parameters.AddWithValue("@date", date);
            cmd.Parameters.AddWithValue("@hours", hours);
            cmd.Parameters.AddWithValue("@rd", DateTime.Now);

            cmd.Prepare();
            cmd.ExecuteNonQuery();

            Connector.Connector.CloseConnection(con);
        }

        public static DataTable Get()
        {
            var output = new DataTable();

            using var con = new NpgsqlConnection("Host=localhost;Username=postgres;Password=2862;Database=IPCACC");
            var sql = "SELECT * FROM cc.pedido_credito_horas";

            using var cmd = new NpgsqlCommand(sql, con);
            using var da = new NpgsqlDataAdapter(cmd);
            da.Fill(output);
            return output;
        }

        public static DataTable GetByCodTeacher(int cod)
        {
            var output = new DataTable();

            using var con = new NpgsqlConnection("Host=localhost;Username=postgres;Password=2862;Database=IPCACC");
            var sql = $"SELECT * FROM cc.pedido_credito_horas WHERE cod_docente = {cod}";

            using var cmd = new NpgsqlCommand(sql, con);
            using var da = new NpgsqlDataAdapter(cmd);
            da.Fill(output);
            return output;
        }

        public static void Remove(int cod)
        {
            using var con = new NpgsqlConnection("Host=localhost;Username=postgres;Password=2862;Database=IPCACC");
            var sql = $"DELETE FROM cc.pedido_credito_horas WHERE cod_pedido = {cod}";
            con.Open();
            using var cmd = new NpgsqlCommand(sql, con);
            cmd.Prepare();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
