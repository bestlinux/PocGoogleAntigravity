using BookRegistry.Shared;

namespace BookRegistry.Client.Services
{
    public interface IBookService
    {
        Task<List<Book>> GetBooks();
        Task<Book?> GetBook(int id);
        Task CreateBook(Book book);
        Task UpdateBook(Book book);
        Task DeleteBook(int id);
    }
}
