using System.Collections.Generic;
using System.Linq;
using FGV.TechnicalEvaluation.Domain.Services;
using FGV.TechnicalEvaluation.Foundation.Contracts;
using FGV.TechnicalEvaluation.Foundation.Entities;
using FGV.TechnicalEvaluation.Tests.Application;
using FGV.TechnicalEvaluation.WebApi.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FGV.TechnicalEvaluation.Tests.WebApi.Controllers
{
    [TestClass]
    public class BookControllerTest
    {
        [TestMethod]
        public void SutPostBooks()
        {
            var context = new TestAppContext(new[] { new Sorting<Book> { Column = c => c.Title, Ascending = true } });
            var service = new BooksOrderer(context);
            var controller = new BookController(context, service);
            IEnumerable<Book> result = controller.Order(new[]
            {
                new Book
                {
                    Title = "Java How to Program",
                    AuthorName = "Deitel & Deitel",
                    EditionYear = 2007
                },
                new Book
                {
                    Title = "Patterns of Enterprise Application Architecture",
                    AuthorName = "Martin Fowler",
                    EditionYear = 2002
                },
                new Book
                {
                    Title = "Head First Design Patterns",
                    AuthorName = "Elisabeth Freeman",
                    EditionYear = 2004
                },
                new Book
                {
                    Title = "Internet & World Wide Web: How to Program",
                    AuthorName = "Deitel & Deitel",
                    EditionYear = 2007
                }
            });
            Assert.IsNotNull(result);
            Assert.AreEqual(4, result.Count());
        }
    }
}
