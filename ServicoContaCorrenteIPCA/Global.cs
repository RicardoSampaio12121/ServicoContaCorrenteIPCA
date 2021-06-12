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

        private static float _SAmount = 0;

        private static int _codDocente = 0;

        private static string _motivo = "";

        public static float Value
        {
            get { return _value; }
            set { _value = value; }
        }

        public static float SAmount
        {
            get { return _SAmount; }
            set { _SAmount = value; }
        }

        public static int CodDoc
        {
            get { return _codDocente; }
            set { _codDocente = value; }
        }

        public static string Motivo
        {
            get { return _motivo; }
            set { _motivo = value; }
        }

    }
}
