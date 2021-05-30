using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Entities
{
    public class AcceptedArticleRequest
    {
        private int _cod_pedido;
        private int _teacherId;
        private string _article;
        private string _magazine;
        private DateTime _date;
        float _value;

        public AcceptedArticleRequest(int cod_pedido, int teacher_Id, string article, string magazine, DateTime date, float value)
        {
            this._cod_pedido = cod_pedido;
            this._teacherId = teacher_Id;
            this._article = article;
            this._magazine = magazine;
            this._date = date;
            this._value = value;
        }

        public int CodPedido { get => _cod_pedido; }
        public int TeacherId { get => _teacherId; }
        public string Article { get => _article; }
        public string Magazine { get => _magazine; }
        public DateTime Date { get => _date; }
        public float Value { get => _value; }





    }
}
