using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BookRegistry.Server.Data;
using BookRegistry.Shared;

namespace BookRegistry.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PublishersController : ControllerBase
    {
        private readonly AppDbContext _context;

        public PublishersController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Publishers
        [HttpGet]
        public async Task<ActionResult<PaginatedResult<Publisher>>> GetPublishers([FromQuery] int? page, [FromQuery] int? pageSize)
        {
            // Se não houver parâmetros de paginação, retornar todos
            if (!page.HasValue || !pageSize.HasValue)
            {
                var allPublishers = await _context.Publishers.ToListAsync();
                return new PaginatedResult<Publisher>
                {
                    Items = allPublishers,
                    TotalCount = allPublishers.Count,
                    PageNumber = 1,
                    PageSize = allPublishers.Count,
                    TotalPages = 1
                };
            }

            var totalCount = await _context.Publishers.CountAsync();
            var totalPages = (int)Math.Ceiling(totalCount / (double)pageSize.Value);
            
            var publishers = await _context.Publishers
                .Skip((page.Value - 1) * pageSize.Value)
                .Take(pageSize.Value)
                .ToListAsync();

            return new PaginatedResult<Publisher>
            {
                Items = publishers,
                TotalCount = totalCount,
                PageNumber = page.Value,
                PageSize = pageSize.Value,
                TotalPages = totalPages
            };
        }

        // GET: api/Publishers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Publisher>> GetPublisher(int id)
        {
            var publisher = await _context.Publishers.FindAsync(id);
            if (publisher == null)
            {
                return NotFound();
            }
            return publisher;
        }

        // POST: api/Publishers
        [HttpPost]
        public async Task<ActionResult<Publisher>> CreatePublisher(Publisher publisher)
        {
            _context.Publishers.Add(publisher);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetPublisher), new { id = publisher.Id }, publisher);
        }

        // PUT: api/Publishers/5
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdatePublisher(int id, Publisher publisher)
        {
            if (id != publisher.Id)
            {
                return BadRequest();
            }

            _context.Entry(publisher).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PublisherExists(id))
                {
                    return NotFound();
                }
                throw;
            }

            return NoContent();
        }

        // DELETE: api/Publishers/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePublisher(int id)
        {
            var publisher = await _context.Publishers.FindAsync(id);
            if (publisher == null)
            {
                return NotFound();
            }

            // Verificar se há livros associados
            var hasBooks = await _context.Books.AnyAsync(b => b.PublisherId == id);
            if (hasBooks)
            {
                return BadRequest("Não é possível excluir uma editora que possui livros associados.");
            }

            _context.Publishers.Remove(publisher);
            await _context.SaveChangesAsync();
            return NoContent();
        }

        private bool PublisherExists(int id)
        {
            return _context.Publishers.Any(e => e.Id == id);
        }
    }
}
