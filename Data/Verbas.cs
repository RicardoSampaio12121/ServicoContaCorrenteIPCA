using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace Data
{
    public static class Verbas
    {
        /// <summary>
        /// Insere na tabela
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cod_doc"></param>
        public static void InsertArticle(int id, int cod_doc)
        {
            using var con = new NpgsqlConnection("Host=localhost;Username=postgres;Password=2862;Database=IPCACC");
            con.Open();

            var sql = $"INSERT INTO cc.verbas (id_pedido_aceite, cod_docente) VALUES ('{id}', '{cod_doc}')";

            using var cmd = new NpgsqlCommand(sql, con);

            cmd.Prepare();
            cmd.ExecuteNonQuery();

            Connector.Connector.CloseConnection(con);
        }

        /// <summary>
        /// Insere na tabela
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cod_doc"></param>
        public static void InsertHours(int id, int cod_doc)
        {
            using var con = new NpgsqlConnection("Host=localhost;Username=postgres;Password=2862;Database=IPCACC");
            con.Open();

            var sql = $"INSERT INTO cc.verbas_horas (id_horas_aceites, cod_docente) VALUES ('{id}', '{cod_doc}')";

            using var cmd = new NpgsqlCommand(sql, con);

            cmd.Prepare();
            cmd.ExecuteNonQuery();

            Connector.Connector.CloseConnection(con);
        }

        /// <summary>
        /// Retorna informação sobre verba
        /// </summary>
        /// <param name="cod_docente"></param>
        /// <returns></returns>
        public static DataTable GetHours(int cod_docente)
        {
            var output = new DataTable();

            using var con = new NpgsqlConnection("Host=localhost;Username=postgres;Password=2862;Database=IPCACC");
            con.Open();

            var sql = $"SELECT * From cc.verbas_horas INNER JOIN cc.pedidos_aceites_horas on cc.verbas_horas.id_horas_aceites = cc.pedidos_aceites_horas.id INNER JOIN cc.horas_extra on cc.pedidos_aceites_horas.id_horas = cc.horas_extra.id WHERE cc.verbas_horas.cod_docente = {cod_docente}";
            using var cmd = new NpgsqlCommand(sql, con);
            using var da = new NpgsqlDataAdapter(cmd);
            da.Fill(output);
            return output;
        }

        /// <summary>
        /// Retorna informação sobre verba
        /// </summary>
        /// <param name="cod_docente"></param>
        /// <returns></returns>
        public static DataTable GetArtigos(int cod_docente)
        {
            var output = new DataTable();

            using var con = new NpgsqlConnection("Host=localhost;Username=postgres;Password=2862;Database=IPCACC");
            con.Open();

            var sql = $"SELECT * From cc.verbas INNER JOIN cc.pedidos_aceites_ativos on cc.verbas.id_pedido_aceite = cc.pedidos_aceites_ativos.id INNER JOIN cc.artigos_publicados on cc.pedidos_aceites_ativos.cod_artigo = cc.artigos_publicados.id WHERE cc.verbas.cod_docente = {cod_docente}";
            using var cmd = new NpgsqlCommand(sql, con);
            using var da = new NpgsqlDataAdapter(cmd);
            da.Fill(output);
            return output;
        }

        /// <summary>
        /// Remove da tabela
        /// </summary>
        /// <param name="cod_doc"></param>
        public static void DeleteArtigo(int cod_doc)
        {
            using var con = new NpgsqlConnection("Host=localhost;Username=postgres;Password=2862;Database=IPCACC");
            var sql = $"DELETE FROM cc.verbas WHERE cod_docente = {cod_doc}";
            con.Open();
            using var cmd = new NpgsqlCommand(sql, con);
            cmd.Prepare();
            cmd.ExecuteNonQuery();
            con.Close();
        }
         /// <summary>
         /// Remove da tabela
         /// </summary>
         /// <param name="cod_doc"></param>
        public static void DeleteHours(int cod_doc)
        {
            using var con = new NpgsqlConnection("Host=localhost;Username=postgres;Password=2862;Database=IPCACC");
            var sql = $"DELETE FROM cc.verbas_horas WHERE cod_docente = {cod_doc}";
            con.Open();
            using var cmd = new NpgsqlCommand(sql, con);
            cmd.Prepare();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        /// <summary>
        /// Retorna as verbas por docente
        /// </summary>
        /// <param name="cod_doc"></param>
        /// <returns></returns>
        public static List<int> GetVerbasHours(int cod_doc)
        {
            var table = new DataTable();
            int i = 0;
            List<int> output = new List<int>();

            using var con = new NpgsqlConnection("Host=localhost;Username=postgres;Password=2862;Database=IPCACC");
            con.Open();

            var sql = $"SELECT id_horas_aceites FROM cc.verbas_horas WHERE cod_docente = {cod_doc}";
            using var cmd = new NpgsqlCommand(sql, con);
            using var da = new NpgsqlDataAdapter(cmd);
            da.Fill(table);
            
            foreach(DataRow dataRow in table.Rows)
            {
                output.Add(int.Parse(dataRow[0].ToString()));
                i++;
            }

            return output;
        }

        /// <summary>
        /// Retorna as verbas por docente
        /// </summary>
        /// <param name="cod_doc"></param>
        /// <returns></returns>
        public static List<int> GetVerbasArtigos(int cod_doc)
        {
            var table = new DataTable();
            int i = 0;
            List<int> output = new List<int>();

            using var con = new NpgsqlConnection("Host=localhost;Username=postgres;Password=2862;Database=IPCACC");
            con.Open();

            var sql = $"SELECT id_pedido_aceite FROM cc.verbas WHERE cod_docente = {cod_doc}";
            using var cmd = new NpgsqlCommand(sql, con);
            using var da = new NpgsqlDataAdapter(cmd);
            da.Fill(table);

            foreach (DataRow dataRow in table.Rows)
            {
                output.Add(int.Parse(dataRow[0].ToString()));
                i++;
            }

            return output;
        }
    }
}