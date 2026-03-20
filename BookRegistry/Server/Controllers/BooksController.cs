using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BookRegistry.Server.Data;
using BookRegistry.Shared;

namespace BookRegistry.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly AppDbContext _context;

        public BooksController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Book>>> GetBooks()
        {
            return await _context.Books.Include(b => b.Publisher).ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Book>> GetBook(int id)
        {
            var book = await _context.Books.Include(b => b.Publisher).FirstOrDefaultAsync(b => b.Id == id);
            if (book == null)
            {
                return NotFound();
            }
            return book;
        }

        [HttpPost]
        public async Task<ActionResult<Book>> CreateBook(Book book)
        {
            _context.Books.Add(book);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetBook), new { id = book.Id }, book);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateBook(int id, Book book)
        {
            if (id != book.Id)
            {
                return BadRequest();
            }

            var existingBook = await _context.Books.FindAsync(id);
            if (existingBook == null)
            {
                return NotFound();
            }

            // Manually update properties to ensure changes are tracked correctly
            existingBook.Title = book.Title;
            existingBook.Author = book.Author;
            existingBook.PublishDate = book.PublishDate;
            existingBook.ISBN = book.ISBN;
            existingBook.PublisherId = book.PublisherId;
            existingBook.CoverImageBase64 = book.CoverImageBase64;
            existingBook.IsRead = book.IsRead;
            existingBook.ReadingEndDate = book.ReadingEndDate;

            try 
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BookExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        private bool BookExists(int id)
        {
            return _context.Books.Any(e => e.Id == id);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBook(int id)
        {
            var book = await _context.Books.FindAsync(id);
            if (book == null)
            {
                return NotFound();
            }

            _context.Books.Remove(book);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
