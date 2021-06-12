using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Logic.Entities;

namespace Logic.Application
{
    public static class Application
    {

        /// <summary>
        /// Aceite um pedido de credito por artigo
        /// </summary>
        /// <param name="aar"></param>
        public static void AcceptArticleRequest(AcceptedArticleRequest aar)
        {
            // Adicionar artigo à tabela de artigos publicados
            PublishedArticles.Insert(aar.TeacherId, aar.Article, aar.Magazine, aar.Date);

            // Adicionar à tabela dos pedidos de creditos por artigos aceites
            AcceptedRequestCreditsArticle.Insert(aar.Value, aar.TeacherId, aar.Article, aar.Magazine);

            // Remover da tabela de pedidos pendentes
            RequestCreditsArticle.Delete(aar.CodPedido);
        }

        /// <summary>
        /// Aceita um pedido de credito por horas extra
        /// </summary>
        /// <param name="ahr"></param>
        public static void AcceptedHoursRequest(AcceptedHoursRequest ahr)
        {
            // Adicionar à tabela de horas dadas
            HoursGiven.Insert(ahr.TeacherId, ahr.Date, ahr.GivenHours);

            // Adicionar à tabela dos creditos aceites por horas-extra
            AcceptedRequestCreditsHours.Insert(ahr.TeacherId, ahr.Date, ahr.Value);

            //Remover da tabela dos pedidos pendentes
            RequestCreditsHours.Remove(ahr.CodPedido);
        }

        
        /// <summary>
        /// Faz uma solicitação
        /// </summary>
        /// <param name="cod_doc"></param>
        /// <param name="motivo"></param>
        /// <param name="valor"></param>
        /// <param name="verbas"></param>
        public static void MakeSolicitation(int cod_doc, string motivo, float valor, List<(string, int)> verbas)
        {
            // Adicionar À tabela de verbas
            foreach(var verba in verbas)
            {
                if(verba.Item1 == "Artigo")
                {
                    Verbas.InsertArticle(verba.Item2, cod_doc);
                }
                else
                {
                    Verbas.InsertHours(verba.Item2, cod_doc);
                }
            }

            // Adicionar à tabela de solicitações

            Solicitações.Insert(cod_doc, motivo, valor);
        }

        /// <summary>
        /// Aceita uma solicitação
        /// </summary>
        /// <param name="cod_sol"></param>
        /// <param name="cod_doc"></param>
        /// <param name="motivo"></param>
        /// <param name="valor"></param>
        public static void AcceptSolicitation(int cod_sol, int cod_doc, string motivo, float valor)
        {
            //Primeiro inserir na tabela das solicitações aceites
            SolicitacoesAceites.Insert(cod_doc, motivo, valor);

            //Eliminar pedido de solicitação
            Solicitações.Delete(cod_sol);

            //Buscar id's dos pedidos_aceites
            var verbasH = Verbas.GetVerbasHours(cod_doc);
            var verbasA = Verbas.GetVerbasArtigos(cod_doc);

            float remainding = valor;

            //Buscar valor dos pedidos aceites
            if (verbasH.Count > 0)
            {
                var valoresH = AcceptedRequestCreditsHours.GetValues(verbasH);

                Verbas.DeleteHours(cod_doc);

                foreach (var a in valoresH)
                {
                    remainding -= a.Value;
                    if (remainding > 0)
                    {
                        AcceptedRequestCreditsHours.Remove(a.Key);
                    }
                    else
                    {
                        AcceptedRequestCreditsHours.Update(a.Key, Math.Abs(remainding));
                    }
                }
            }

            if(verbasA.Count > 0)
            {
                var valoresA = AcceptedRequestCreditsArticle.GetValues(verbasA);

                Verbas.DeleteArtigo(cod_doc);

                if (remainding > 0)
                {
                    foreach (var a in valoresA)
                    {
                        remainding -= a.Value;
                        if (remainding > 0)
                        {
                            AcceptedRequestCreditsArticle.Remove(a.Key);
                        }
                        else
                        {
                            AcceptedRequestCreditsArticle.Update(a.Key, Math.Abs(remainding));
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Rejeita uma solicitação
        /// </summary>
        /// <param name="cod_sol"></param>
        /// <param name="cod_docente"></param>
        public static void RejectSolicitation(int cod_sol, int cod_docente)
        {
            //Apagar da tabela de solicitações pendentes
            Solicitações.Delete(cod_sol);

            //Eliminar da tabela de verbas
            Verbas.DeleteHours(cod_docente);
            Verbas.DeleteArtigo(cod_docente);
        }

        /// <summary>
        /// Recebe todas as solicitações
        /// </summary>
        /// <returns></returns>
        public static DataTable GetSolicitations()
        {
            return Solicitações.Get();
        }

        /// <summary>
        /// Recebe dolicitações por ID
        /// </summary>
        /// <param name="cod_docente"></param>
        /// <returns></returns>
        public static DataTable GetSolicitationsById(int cod_docente)
        {
            return Solicitações.GetSolicitationsById(cod_docente);
        }

        /// <summary>
        /// Recebe verbas por horas
        /// </summary>
        /// <param name="cod_docente"></param>
        /// <returns></returns>
        public static DataTable GetVerbasHoras(int cod_docente)
        {
            return Verbas.GetHours(cod_docente);
        }

        /// <summary>
        /// Recebe verbas por artigo
        /// </summary>
        /// <param name="cod_docente"></param>
        /// <returns></returns>
        public static DataTable GetVerbasArtigos(int cod_docente)
        {
            return Verbas.GetArtigos(cod_docente);
        }
    }
}