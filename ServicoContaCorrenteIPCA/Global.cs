using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicoContaCorrenteIPCA
{
    class Global
    {
        private static float _value = 0;

        public static float Value
        {
            get { return _value; }
            set { _value = value; }
        }
    }
}
