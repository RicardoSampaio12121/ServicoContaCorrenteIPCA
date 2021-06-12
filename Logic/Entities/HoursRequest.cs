using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;

namespace Logic.Entities
{
    public class HoursRequest
    {
        private readonly int _teacherId;
        private readonly string _date;
        private readonly float _hours;
        
        public HoursRequest() { }

        public HoursRequest(int teacherId, string date, float hours)
        {
            this._teacherId = teacherId;
            this._date= date;
            this._hours = hours;
        }

        /// <summary>
        /// Faz um pedido de credito
        /// </summary>
        public void MakeRequest()
        {
            RequestCreditsHours.InsertRequest(_teacherId, DateTime.Parse(_date), _hours);
        }

        /// <summary>
        /// Retorna todos os pedidos de credito
        /// </summary>
        /// <returns></returns>
        public DataTable Get()
        {
            return RequestCreditsHours.Get();
        }
        
        /// <summary>
        /// Retorna todos os pedidos de credito por código de docente
        /// </summary>
        /// <param name="cod"></param>
        /// <returns></returns>
        public DataTable GetByCodTeacher(int cod)
        {
            return RequestCreditsHours.GetByCodTeacher(cod);
        }

        /// <summary>
        /// Remove um pedido de credito
        /// </summary>
        /// <param name="cod"></param>
        public void Remove(int cod)
        {
            RequestCreditsHours.Remove(cod);
        }
    }
}
