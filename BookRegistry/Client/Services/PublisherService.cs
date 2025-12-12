using System.Net.Http.Json;
using BookRegistry.Shared;

namespace BookRegistry.Client.Services
{
    public class PublisherService : IPublisherService
    {
        private readonly HttpClient _http;

        public PublisherService(HttpClient http)
        {
            _http = http;
        }

        public async Task<List<Publisher>> GetPublishers()
        {
            var result = await _http.GetFromJsonAsync<PaginatedResult<Publisher>>("api/publishers");
            return result?.Items ?? new List<Publisher>();
        }

        public async Task<PaginatedResult<Publisher>> GetPublishersPaginated(int page, int pageSize)
        {
            return await _http.GetFromJsonAsync<PaginatedResult<Publisher>>($"api/publishers?page={page}&pageSize={pageSize}") 
                ?? new PaginatedResult<Publisher>();
        }

        public async Task<Publisher?> GetPublisher(int id)
        {
            return await _http.GetFromJsonAsync<Publisher>($"api/publishers/{id}");
        }

        public async Task CreatePublisher(Publisher publisher)
        {
            await _http.PostAsJsonAsync("api/publishers", publisher);
        }

        public async Task UpdatePublisher(Publisher publisher)
        {
            await _http.PutAsJsonAsync($"api/publishers/{publisher.Id}", publisher);
        }

        public async Task DeletePublisher(int id)
        {
            await _http.DeleteAsync($"api/publishers/{id}");
        }
    }
}
