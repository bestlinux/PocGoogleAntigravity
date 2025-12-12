using BookRegistry.Shared;

namespace BookRegistry.Client.Services
{
    public interface IPublisherService
    {
        Task<List<Publisher>> GetPublishers();
        Task<PaginatedResult<Publisher>> GetPublishersPaginated(int page, int pageSize);
        Task<Publisher?> GetPublisher(int id);
        Task CreatePublisher(Publisher publisher);
        Task UpdatePublisher(Publisher publisher);
        Task DeletePublisher(int id);
    }
}
