using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace Data.Connector
{
    public interface IConnector
    {
        static NpgsqlConnection OpenConnection { get; }

        void CloseConnectior();
    }
}
