using System.Collections.Generic;
using FGV.TechnicalEvaluation.Foundation.Entities;

namespace FGV.TechnicalEvaluation.Foundation.Contracts.Services
{
    public interface IBooksOrderer
    {
        IEnumerable<Book> Order(IEnumerable<Book> books);
    }
}