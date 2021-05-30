using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Entities
{
    public class AcceptedHoursRequest
    {
        private int _codPedido;
        private int _teacherId;
        private DateTime _date;
        private float _givenHours;
        private float _value;

        public AcceptedHoursRequest(int codPedido, int teacherId, DateTime date, float givenHours, float value)
        {
            this._codPedido = codPedido;
            this._teacherId = teacherId;
            this._date = date;
            this._givenHours = givenHours;
            this._value = value;
        }


        public int CodPedido { get => _codPedido; }
        public int TeacherId { get => _teacherId; }
        public DateTime Date { get => _date; }
        public float GivenHours { get => _givenHours; }
        public float Value { get => _value; }
    }
}
