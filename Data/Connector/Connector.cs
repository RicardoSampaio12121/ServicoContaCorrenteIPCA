using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;


namespace Data.Connector
{
    public static class Connector
    {
        private const string cs = "Host=localhost;Username=postgres;Password=2862;Database=IPCACC";
        public static void CloseConnection(NpgsqlConnection con)
        {
            con.Close();
        }

        public static NpgsqlConnection OpenConnection()
        {
            using var con = new NpgsqlConnection(cs);
            con.Open();

            return con;
        }
    }
}
