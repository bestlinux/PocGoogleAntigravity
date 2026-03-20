using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BookRegistry.Server.Data;
using BookRegistry.Shared;

namespace BookRegistry.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReadingSessionController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ReadingSessionController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<ActionResult<ReadingSession>> CreateReadingSession(ReadingSession session)
        {
            _context.ReadingSessions.Add(session);
            
            if (session.IsFinalSession)
            {
                var book = await _context.Books.FindAsync(session.BookId);
                if (book != null)
                {
                    book.IsRead = true;
                    book.ReadingEndDate = session.EndTime;
                    _context.Entry(book).State = EntityState.Modified;
                }
            }

            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetReadingSession), new { id = session.Id }, session);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ReadingSession>> GetReadingSession(int id)
        {
            var session = await _context.ReadingSessions.FindAsync(id);
            if (session == null)
            {
                return NotFound();
            }
            return session;
        }

        [HttpGet("book/{bookId}")]
        public async Task<ActionResult<List<ReadingSession>>> GetSessionsByBook(int bookId)
        {
            return await _context.ReadingSessions
                .Where(s => s.BookId == bookId)
                .OrderByDescending(s => s.StartTime)
                .ToListAsync();
        }
    }
}
