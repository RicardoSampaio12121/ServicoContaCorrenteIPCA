using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DatabaseConnector
{
    interface IConnector
    {
        void OpenConnection();
        void CloseConnection();
    }
}
