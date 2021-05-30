using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace Data
{
    public class AcceptedRequestCreditsArticle
    {

        public static void Insert(float val, int cod_doc, string artigo, string revista)
        {
            using var con = new NpgsqlConnection("Host=localhost;Username=postgres;Password=2862;Database=IPCACC");
            con.Open();

            var sql = $"INSERT INTO cc.pedidos_aceites_ativos (cod_artigo, valor) VALUES ((SELECT id FROM cc.artigos_publicados WHERE cod_docente = {cod_doc} AND artigo = '{artigo}' AND revista = '{revista}'), {val});";
            using var cmd = new NpgsqlCommand(sql, con);


            cmd.Prepare();
            cmd.ExecuteNonQuery();

            Connector.Connector.CloseConnection(con);
        }



    }
}
