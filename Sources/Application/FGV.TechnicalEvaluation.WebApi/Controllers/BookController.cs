using System.Collections.Generic;
using System.Web.Http;
using FGV.TechnicalEvaluation.Foundation.Contracts;
using FGV.TechnicalEvaluation.Foundation.Contracts.Services;
using FGV.TechnicalEvaluation.Foundation.Entities;

namespace FGV.TechnicalEvaluation.WebApi.Controllers
{
    /// <summary>
    /// Serviço de administração de livros
    /// </summary>
    [RoutePrefix("books")]
    public class BookController : BaseController
    {
        private readonly IBooksOrderer _booksOrderer;

        public BookController(IApplicationContext applicationContext, IBooksOrderer booksOrderer) : base(applicationContext)
        {
            _booksOrderer = booksOrderer;
        }

        /// <summary>
        /// Ordenação de livros mediante prévia configuração de colunas.
        /// As configurações devem ser aplicadas no arquivo Web.config
        /// </summary>
        /// <param name="books">Lista de livros a ser ordenada</param>
        /// <returns>Retorna a lista de livros ordenada</returns>
        [Route("order")]
        [HttpPost]
        public IEnumerable<Book> Order(IEnumerable<Book> books)
        {
            return _booksOrderer.Order(books);
        }
    }
}