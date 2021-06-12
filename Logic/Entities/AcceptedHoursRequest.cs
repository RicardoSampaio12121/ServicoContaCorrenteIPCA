using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;

namespace Logic.Entities
{
    public class AcceptedHoursRequest
    {
        private int _codPedido;
        private int _teacherId;
        private DateTime _date;
        private float _givenHours;
        private float _value;


        public AcceptedHoursRequest() { }
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


        /// <summary>
        /// Retorna todos os pedidos de credito aceites
        /// </summary>
        /// <returns></returns>
        public DataTable Get()
        {
            return AcceptedRequestCreditsHours.Get();
        }

        /// <summary>
        /// Retorna todos os pedidos de credito aceites por docente
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public DataTable GetById(int id)
        {
            return AcceptedRequestCreditsHours.GetById(id);
        }
    }
}
