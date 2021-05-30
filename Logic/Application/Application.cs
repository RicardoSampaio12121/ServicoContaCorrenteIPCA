using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Logic.Entities;

namespace Logic.Application
{
    public static class Application
    {

        public static void AcceptArticleRequest(AcceptedArticleRequest aar)
        {
            // Adicionar artigo à tabela de artigos publicados
            PublishedArticles.Insert(aar.TeacherId, aar.Article, aar.Magazine, aar.Date);

            // Adicionar à tabela dos pedidos de creditos por artigos aceites
            AcceptedRequestCreditsArticle.Insert(aar.Value, aar.TeacherId, aar.Article, aar.Magazine);

            // Remover da tabela de pedidos pendentes
            RequestCreditsArticle.Delete(aar.CodPedido);
        }

        public static void AcceptedHoursRequest(AcceptedHoursRequest ahr)
        {
            // Adicionar à tabela de horas dadas
            HoursGiven.Insert(ahr.TeacherId, ahr.Date, ahr.GivenHours);

            // Adicionar à tabela dos creditor aceites por horas-extra
            AcceptedRequestCreditsHours.Insert(ahr.TeacherId, ahr.Date, ahr.Value);

            //Remover da tabela dos pedidos pendentes
            RequestCreditsHours.Remove(ahr.CodPedido);

        }

    }
}
