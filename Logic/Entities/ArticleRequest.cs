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

        /// <summary>
        /// Faz um pedido de credito
        /// </summary>
        public void MakeRequest()
        {
            RequestCreditsArticle.InsertRequest(_teacherId, _article, _magazine);
        }

        /// <summary>
        /// Retorna todos os pedidos de credito
        /// </summary>
        /// <returns></returns>
        public DataTable Get()
        {
            return RequestCreditsArticle.Get();
        }

        /// <summary>
        /// Retorna todos os pedidos de credito por codigo de docente
        /// </summary>
        /// <param name="cod"></param>
        /// <returns></returns>
        public DataTable GetByCodTeacher(int cod)
        {
            return RequestCreditsArticle.GetByCodTeacher(cod);
        }

        /// <summary>
        /// Remove um pedido de credito por codigo de docente
        /// </summary>
        /// <param name="cod"></param>
        public void Remove(int cod)
        {
            RequestCreditsArticle.Delete(cod);
        }
    }
}
