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

        public void MakeRequest()
        {
            RequestCreditsHours.InsertRequest(_teacherId, DateTime.Parse(_date), _hours);
        }

        public DataTable Get()
        {
            return RequestCreditsHours.Get();
        }
        
        public DataTable GetByCodTeacher(int cod)
        {
            return RequestCreditsHours.GetByCodTeacher(cod);
        }

        public void Remove(int cod)
        {
            RequestCreditsHours.Remove(cod);
        }
    }
}
