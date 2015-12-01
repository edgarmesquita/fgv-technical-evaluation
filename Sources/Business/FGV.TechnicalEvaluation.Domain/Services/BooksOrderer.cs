using System.Linq;
using System.Linq.Dynamic;
using System.Collections.Generic;
using FGV.TechnicalEvaluation.Domain.Exceptions;
using FGV.TechnicalEvaluation.Domain.Resources;
using FGV.TechnicalEvaluation.Foundation.Contracts;
using FGV.TechnicalEvaluation.Foundation.Contracts.Services;
using FGV.TechnicalEvaluation.Foundation.Entities;

namespace FGV.TechnicalEvaluation.Domain.Services
{
    /// <summary>
    /// Serviço de ordenação de livros
    /// </summary>
    public class BooksOrderer : IBooksOrderer
    {
        private readonly IApplicationContext _applicationContext;

        public BooksOrderer(IApplicationContext applicationContext)
        {
            _applicationContext = applicationContext;
        }

        /// <summary>
        /// Obtém uma lista de livros ordenadas mediante configuração de colunas especificado no contexto da aplicação
        /// </summary>
        /// <param name="books">Lista de livros a ser ordenada</param>
        /// <returns>Retorna lista ordenada de livros</returns>
        public IEnumerable<Book> Order(IEnumerable<Book> books)
        {
            if (books.Any())
            {
                var columns = _applicationContext.BookOrdenation;
                if (columns == null) throw new OrdenationException(DomainResource.BooksOrdererNullArgumentExceptionMessage);

                if (columns.Any())
                {
                    var cols = columns.ToList();
                    cols.Reverse();

                    return cols.Aggregate(books,
                        (current, sortingColumn) =>
                            current.OrderBy(sortingColumn.ColumnName + (sortingColumn.Ascending ? "" : " descending")));
                }
                return new Book[0];
            }
            return books;
        }
    }
}