using Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using System.Data;

namespace Logic.Entities
{
    public class ArticleRequest : IArticleRequest
    {
        private readonly int _teacherId;
        private readonly string _article;
        private readonly string _magazine;

        public ArticleRequest() { }

        public ArticleRequest(int teacherId, string article, string magazine)
        {
            this._teacherId = teacherId;
            this._article = article;
            this._magazine = magazine;
        }

        public void MakeRequest()
        {
            RequestCreditsArticle.InsertRequest(_teacherId, _article, _magazine);
        }

        public DataTable Get()
        {
            return RequestCreditsArticle.Get();
        }
        public DataTable GetByCodTeacher(int cod)
        {
            return RequestCreditsArticle.GetByCodTeacher(cod);
        }

        public void Remove(int cod)
        {
            RequestCreditsArticle.Delete(cod);
        }
    }
}
