using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace Data
{
    public class AcceptedRequestCreditsArticle
    {
        /// <summary>
        /// Insere na tabela
        /// </summary>
        /// <param name="val"></param>
        /// <param name="cod_doc"></param>
        /// <param name="artigo"></param>
        /// <param name="revista"></param>
        public static void Insert(float val, int cod_doc, string artigo, string revista)
        {
            using var con = new NpgsqlConnection("Host=localhost;Username=postgres;Password=2862;Database=IPCACC");
            con.Open();

            var sql = $"INSERT INTO cc.pedidos_aceites_ativos (cod_artigo, valor, expiration_date, cod_docente) VALUES ((SELECT id FROM cc.artigos_publicados WHERE cod_docente = {cod_doc} AND artigo = '{artigo}' AND revista = '{revista}'), {val}, '{DateTime.Parse(DateTime.Now.AddYears(2).ToShortDateString())}', {cod_doc});";
            using var cmd = new NpgsqlCommand(sql, con);


            cmd.Prepare();
            cmd.ExecuteNonQuery();

            Connector.Connector.CloseConnection(con);
        }

        /// <summary>
        /// Retirna pedidos aceites da tabela
        /// </summary>
        /// <returns></returns>
        public static DataTable Get()
        {
            var output = new DataTable();

            using var con = new NpgsqlConnection("Host=localhost;Username=postgres;Password=2862;Database=IPCACC");
            var sql = "SELECT * FROM cc.pedidos_aceites_ativos";

            using var cmd = new NpgsqlCommand(sql, con);
            using var da = new NpgsqlDataAdapter(cmd);
            da.Fill(output);
            return output;
        }

        /// <summary>
        /// Retorna pedidos aceites por docente
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static  DataTable GetById(int id)
        {
            var output = new DataTable();

            using var con = new NpgsqlConnection("Host=localhost;Username=postgres;Password=2862;Database=IPCACC");
            var sql = $"SELECT * FROM cc.pedidos_aceites_ativos WHERE cod_docente = {id}";

            using var cmd = new NpgsqlCommand(sql, con);
            using var da = new NpgsqlDataAdapter(cmd);
            da.Fill(output);
            return output;
        }

        /// <summary>
        /// Remove pedido aceite da tabela
        /// </summary>
        /// <param name="id"></param>
        public static void Remove(int id)
        {
            using var con = new NpgsqlConnection("Host=localhost;Username=postgres;Password=2862;Database=IPCACC");
            var sql = $"DELETE FROM cc.pedidos_aceites_ativos WHERE id = {id}";
            con.Open();
            using var cmd = new NpgsqlCommand(sql, con);
            cmd.Prepare();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        /// <summary>
        /// Atualiza valor de um pedido da tabela
        /// </summary>
        /// <param name="id"></param>
        /// <param name="valor"></param>
        public static void Update(int id, float valor)
        {
            using var con = new NpgsqlConnection("Host=localhost;Username=postgres;Password=2862;Database=IPCACC");
            var sql = $"UPDATE cc.pedidos_aceites_ativos SET valor = {valor} WHERE id = {id}";
            con.Open();
            using var cmd = new NpgsqlCommand(sql, con);
            cmd.Prepare();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        /// <summary>
        /// Retorna os valores de pedidos da tabela dado os id's dos pedidos
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

            var sql = $"SELECT id, valor FROM cc.pedidos_aceites_ativos WHERE id in ({string.Join(",", ids)})";
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
