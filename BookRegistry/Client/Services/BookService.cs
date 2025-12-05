using System.Net.Http.Json;
using BookRegistry.Shared;

namespace BookRegistry.Client.Services
{
    public class BookService : IBookService
    {
        private readonly HttpClient _http;

        public BookService(HttpClient http)
        {
            _http = http;
        }

        public async Task<List<Book>> GetBooks()
        {
            return await _http.GetFromJsonAsync<List<Book>>("api/books") ?? new List<Book>();
        }

        public async Task<Book?> GetBook(int id)
        {
            return await _http.GetFromJsonAsync<Book>($"api/books/{id}");
        }

        public async Task CreateBook(Book book)
        {
            await _http.PostAsJsonAsync("api/books", book);
        }

        public async Task UpdateBook(Book book)
        {
            await _http.PutAsJsonAsync($"api/books/{book.Id}", book);
        }

        public async Task DeleteBook(int id)
        {
            await _http.DeleteAsync($"api/books/{id}");
        }
    }
}
