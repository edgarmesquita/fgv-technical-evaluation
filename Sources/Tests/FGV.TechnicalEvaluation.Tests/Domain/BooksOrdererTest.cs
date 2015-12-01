using System;
using System.Linq;
using FGV.TechnicalEvaluation.Domain.Exceptions;
using FGV.TechnicalEvaluation.Domain.Services;
using FGV.TechnicalEvaluation.Foundation.Contracts;
using FGV.TechnicalEvaluation.Foundation.Contracts.Services;
using FGV.TechnicalEvaluation.Foundation.Entities;
using FGV.TechnicalEvaluation.Tests.Application;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FGV.TechnicalEvaluation.Tests.Domain
{
    /// <summary>
    /// Teste do serviço de domínio BooksOrderer
    /// </summary>
    [TestClass]
    public class BooksOrdererTest
    {
        private Book[] GetBooks()
        {
            return new[]
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
            };
        }

        /// <summary>
        /// Garante a ordenação por título ascendente
        /// </summary>
        [TestMethod]
        public void SutOrderByTitleAscending()
        {
            var context = new TestAppContext(new[] { new Sorting<Book> { Column = c => c.Title, Ascending = true } });
            IBooksOrderer orderer = new BooksOrderer(context);
            var books = GetBooks();
            var result = orderer.Order(books);

            Assert.IsNotNull(result);
            Assert.AreEqual("Head First Design Patterns", result.ElementAt(0).Title);
            Assert.AreEqual("Internet & World Wide Web: How to Program", result.ElementAt(1).Title);
            Assert.AreEqual("Java How to Program", result.ElementAt(2).Title);
            Assert.AreEqual("Patterns of Enterprise Application Architecture", result.ElementAt(3).Title);
        }

        /// <summary>
        /// Garante a ordenação por autor ascendente e título descendente
        /// </summary>
        [TestMethod]
        public void SutOrderByAuthorAscendingAndTitleDescending()
        {
            var context =
                new TestAppContext(new[]
                {
                    new Sorting<Book> {Column = c => c.AuthorName, Ascending = true},
                    new Sorting<Book> {Column = c => c.Title, Ascending = false}
                });
            IBooksOrderer orderer = new BooksOrderer(context);
            var books = GetBooks();
            var result = orderer.Order(books);

            Assert.IsNotNull(result);
            Assert.AreEqual("Java How to Program", result.ElementAt(0).Title);
            Assert.AreEqual("Internet & World Wide Web: How to Program", result.ElementAt(1).Title);
            Assert.AreEqual("Head First Design Patterns", result.ElementAt(2).Title);
            Assert.AreEqual("Patterns of Enterprise Application Architecture", result.ElementAt(3).Title);
        }

        /// <summary>
        /// Garante a ordenação por edição descendente, autor descendente e título ascendente
        /// </summary>
        [TestMethod]
        public void SutOrderByEditionDescendingAndAuthorDescendingAndTitleAscending()
        {
            var context =
                new TestAppContext(new[]
                {
                    new Sorting<Book> {Column = c => c.EditionYear, Ascending = false},
                    new Sorting<Book> {Column = c => c.AuthorName, Ascending = false},
                    new Sorting<Book> {Column = c => c.Title, Ascending = true}
                });
            IBooksOrderer orderer = new BooksOrderer(context);
            var books = GetBooks();
            var result = orderer.Order(books);

            Assert.IsNotNull(result);
            Assert.AreEqual("Internet & World Wide Web: How to Program", result.ElementAt(0).Title);
            Assert.AreEqual("Java How to Program", result.ElementAt(1).Title);
            Assert.AreEqual("Head First Design Patterns", result.ElementAt(2).Title);
            Assert.AreEqual("Patterns of Enterprise Application Architecture", result.ElementAt(3).Title);
        }

        /// <summary>
        /// Garante excessão de tipo esperada para ordenação não definida
        /// </summary>
        [TestMethod]
        public void SutNotOrderIfSortingIsNull()
        {
            var context =
                new TestAppContext(null);
            IBooksOrderer orderer = new BooksOrderer(context);
            var books = GetBooks();
            try
            {
                var result = orderer.Order(books);
                Assert.Fail();
            }
            catch (Exception ex)
            {
                Assert.IsInstanceOfType(ex, typeof(OrdenationException));
            }
        }

        /// <summary>
        /// Garante resultado vazio para ordenação vazia
        /// </summary>
        [TestMethod]
        public void SutNotOrderIfSortingIsEmpty()
        {
            var context =
                new TestAppContext(new Sorting<Book>[0]);
            IBooksOrderer orderer = new BooksOrderer(context);
            var books = GetBooks();
            var result = orderer.Order(books);

            Assert.IsFalse(result.Any());
        }
    }
}