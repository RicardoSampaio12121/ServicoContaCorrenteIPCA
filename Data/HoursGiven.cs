using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace Data
{
    public static class HoursGiven
    {
        public static void Insert(int cod_doc, DateTime date, float hoursGiven)
        {
            using var con = new NpgsqlConnection("Host=localhost;Username=postgres;Password=2862;Database=IPCACC");
            con.Open();

            var sql = "INSERT INTO cc.horas_extra (cod_docente, data, horas_dadas) VALUES (@cod_doc, @data, @hd)";

            using var cmd = new NpgsqlCommand(sql, con);

            cmd.Parameters.AddWithValue("@cod_doc", cod_doc);
            cmd.Parameters.AddWithValue("@data", date);
            cmd.Parameters.AddWithValue("@hd", hoursGiven);

            cmd.Prepare();
            cmd.ExecuteNonQuery();

            Connector.Connector.CloseConnection(con);
        }
    }
}
