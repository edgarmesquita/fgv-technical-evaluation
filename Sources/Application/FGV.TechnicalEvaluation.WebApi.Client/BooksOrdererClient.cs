using System.Net.Http;
using System.Net.Http.Formatting;
using System.Threading.Tasks;
using FGV.TechnicalEvaluation.Foundation.Entities;

namespace FGV.TechnicalEvaluation.WebApi.Client
{
    public class BooksOrdererClient : ClientBase
    {
        public BooksOrdererClient(string baseUri) : base(baseUri)
        {
            
        }

        public async Task<Book[]> OrderAsync(Book[] books)
        {
            var url = "books/order";
            var response = await Client.PostAsync<Book[]>(url, books, new JsonMediaTypeFormatter());
            return await response.Content.ReadAsAsync<Book[]>();
        }
    }
}