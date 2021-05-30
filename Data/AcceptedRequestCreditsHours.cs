using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace Data
{
    public static class AcceptedRequestCreditsHours
    {
        public static void Insert(int cod_doc, DateTime data, float val)
        {
            using var con = new NpgsqlConnection("Host=localhost;Username=postgres;Password=2862;Database=IPCACC");
            con.Open();

            var sql = $"INSERT INTO cc.pedidos_aceites_horas (id_horas, valor, expiration_date) VALUES ((SELECT id FROM cc.horas_extra WHERE cod_docente = {cod_doc} AND data = '{data}'), {val}, '{DateTime.Parse(DateTime.Now.AddYears(2).ToShortDateString())}');";
            using var cmd = new NpgsqlCommand(sql, con);


            cmd.Prepare();
            cmd.ExecuteNonQuery();

            Connector.Connector.CloseConnection(con);
        }
    }
}
