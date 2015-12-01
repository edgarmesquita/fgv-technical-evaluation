using FGV.TechnicalEvaluation.Foundation.Contracts;
using FGV.TechnicalEvaluation.Foundation.Entities;

namespace FGV.TechnicalEvaluation.Tests.Application
{
    public class TestAppContext : IApplicationContext
    {
        public TestAppContext(Sorting<Book>[] bookOrdenation)
        {
            BookOrdenation = bookOrdenation;
        }
        public ISorting[] BookOrdenation { get; private set; }
    }
}