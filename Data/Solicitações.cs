using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace Data
{
    public static class Solicitações
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

            var sql = "INSERT INTO cc.solicitacoes (cod_docente, motivo, valor) VALUES (@cod_doc, @mot, @val)";

            using var cmd = new NpgsqlCommand(sql, con);

            cmd.Parameters.AddWithValue("@cod_doc", cod_doc);
            cmd.Parameters.AddWithValue("@mot", motivo);
            cmd.Parameters.AddWithValue("@val", valor);

            cmd.Prepare();
            cmd.ExecuteNonQuery();

            Connector.Connector.CloseConnection(con);
        }

        /// <summary>
        /// Retorna as solicitações
        /// </summary>
        /// <returns></returns>
        public static DataTable Get()
        {
            var output = new DataTable();

            using var con = new NpgsqlConnection("Host=localhost;Username=postgres;Password=2862;Database=IPCACC");
            con.Open();

            var sql = $"SELECT * FROM cc.solicitacoes";
            using var cmd = new NpgsqlCommand(sql, con);
            using var da = new NpgsqlDataAdapter(cmd);
            da.Fill(output);
            return output;
        }

        /// <summary>
        /// Retorna a solicitação de um docente
        /// </summary>
        /// <param name="cod_docente"></param>
        /// <returns></returns>
        public static DataTable GetSolicitationsById(int cod_docente)
        {
            var output = new DataTable();

            using var con = new NpgsqlConnection("Host=localhost;Username=postgres;Password=2862;Database=IPCACC");
            con.Open();

            //var sql = "SELECT * From cc.solicitacoes INNER JOIN cc.verbas on cc.solicitacoes.cod_docente = cc.verbas.cod_docente INNER JOIN cc.pedidos_aceites_horas on cc.verbas_horas.id_horas_aceites = cc.pedidos_aceites_horas.id WHERE cc.solicitacoes.cod_docente = '2'";
            var sql = $"SELECT * FROM cc.solicitacoes WHERE cod_docente = {cod_docente}";
            using var cmd = new NpgsqlCommand(sql, con);
            using var da = new NpgsqlDataAdapter(cmd);
            da.Fill(output);
            return output;
        }

        /// <summary>
        /// Remove da tabela
        /// </summary>
        /// <param name="cod_sol"></param>
        public static void Delete(int cod_sol)
        {
            using var con = new NpgsqlConnection("Host=localhost;Username=postgres;Password=2862;Database=IPCACC");
            var sql = $"DELETE FROM cc.solicitacoes WHERE id = {cod_sol}";
            con.Open();
            using var cmd = new NpgsqlCommand(sql, con);
            cmd.Prepare();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
