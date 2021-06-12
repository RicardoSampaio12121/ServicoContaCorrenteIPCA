using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace Data
{
    public static class AcceptedRequestCreditsHours
    {
        /// <summary>
        /// Insere na tabela
        /// </summary>
        /// <param name="cod_doc"></param>
        /// <param name="data"></param>
        /// <param name="val"></param>
        public static void Insert(int cod_doc, DateTime data, float val)
        {
            using var con = new NpgsqlConnection("Host=localhost;Username=postgres;Password=2862;Database=IPCACC");
            con.Open();

            var sql = $"INSERT INTO cc.pedidos_aceites_horas (id_horas, valor, expiration_date, cod_docente) VALUES ((SELECT id FROM cc.horas_extra WHERE cod_docente = {cod_doc} AND data = '{data}'), '{val}', '{DateTime.Parse(DateTime.Now.AddYears(2).ToShortDateString())}', '{cod_doc}');";
            using var cmd = new NpgsqlCommand(sql, con);


            cmd.Prepare();
            cmd.ExecuteNonQuery();

            Connector.Connector.CloseConnection(con);
        }

        /// <summary>
        /// Retorna pedidos aceites da tabela
        /// </summary>
        /// <returns></returns>
        public static DataTable Get()
        {
            var output = new DataTable();

            using var con = new NpgsqlConnection("Host=localhost;Username=postgres;Password=2862;Database=IPCACC");
            var sql = "SELECT * FROM cc.pedidos_aceites_horas";

            using var cmd = new NpgsqlCommand(sql, con);
            using var da = new NpgsqlDataAdapter(cmd);
            da.Fill(output);
            return output;
        }

        /// <summary>
        /// Retorna pedidos aceites por id da tabela
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static DataTable GetById(int id)
        {
            var output = new DataTable();

            using var con = new NpgsqlConnection("Host=localhost;Username=postgres;Password=2862;Database=IPCACC");
            var sql = $"SELECT * FROM cc.pedidos_aceites_horas WHERE cod_docente = {id}";

            using var cmd = new NpgsqlCommand(sql, con);
            using var da = new NpgsqlDataAdapter(cmd);
            da.Fill(output);
            return output;
        }

        /// <summary>
        /// Remove pedido da tabela
        /// </summary>
        /// <param name="id"></param>
        public static void Remove(int id)
        {
            using var con = new NpgsqlConnection("Host=localhost;Username=postgres;Password=2862;Database=IPCACC");
            var sql = $"DELETE FROM cc.pedidos_aceites_horas WHERE id = {id}"; 
            con.Open();
            using var cmd = new NpgsqlCommand(sql, con);
            cmd.Prepare();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        /// <summary>
        /// Atualiza valor de pedido da tabela
        /// </summary>
        /// <param name="id"></param>
        /// <param name="valor"></param>
        public static void Update(int id, float valor)
        {
            using var con = new NpgsqlConnection("Host=localhost;Username=postgres;Password=2862;Database=IPCACC");
            var sql = $"UPDATE cc.pedidos_aceites_horas SET valor = {valor} WHERE id = {id}";
            con.Open();
            using var cmd = new NpgsqlCommand(sql, con);
            cmd.Prepare();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        /// <summary>
        /// Retorna os valores de pedidos da tabela dado os seus id's
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public static Dictionary<int, float> GetValues(List<int> ids)
        {
            var table = new DataTable();
            int i = 0;
            Dictionary<int, float> output = new Dictionary<int, float>();

            using var con = new NpgsqlConnection("Host=localhost;Username=postgres;Password=2862;Database=IPCACC");
            con.Open();

            var sql = $"SELECT id, valor FROM cc.pedidos_aceites_horas WHERE id in ({string.Join(",", ids)})";
            using var cmd = new NpgsqlCommand(sql, con);
            using var da = new NpgsqlDataAdapter(cmd);
            da.Fill(table);

            foreach (DataRow dataRow in table.Rows)
            {
                output.Add(int.Parse(dataRow[0].ToString()), float.Parse(dataRow[1].ToString()));
            }

            return output;
        }
    }
}
