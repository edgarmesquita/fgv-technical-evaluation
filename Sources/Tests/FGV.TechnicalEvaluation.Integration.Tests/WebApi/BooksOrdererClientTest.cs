using System.Configuration;
using System.Threading.Tasks;
using FGV.TechnicalEvaluation.Foundation.Entities;
using FGV.TechnicalEvaluation.WebApi.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FGV.TechnicalEvaluation.Integration.Tests.WebApi
{
    [TestClass]
    public class BooksOrdererClientTest
    {
        [TestMethod]
        public async Task SutOrderBooks()
        {
            using (var client = new BooksOrdererClient(ConfigurationManager.AppSettings["app:ApiBaseUrl"]))
            {
                Book[] result = await client.OrderAsync(new[]
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
                Assert.AreEqual(4, result.Length);
            }
        }
    }
}