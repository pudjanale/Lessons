using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using task4.Model;

namespace task4.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BooksController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            using var db = new AppDbContext();
            return Ok(db.Books.AsNoTracking().ToList());
        }

        [HttpPut("{title}")]
        public async Task<IActionResult> Put(string title, [FromQuery(Name = "authtor")] string authtor, [FromQuery(Name = "pages")] int pages)
        {
            using var db = new AppDbContext();
            var exist = await db.Books.AsNoTracking().AnyAsync(b => b.Title == title);
            if (exist) return Conflict();

            Book newBook = new() 
            {
                Title = title,
                Authtor = authtor,
                Pages = pages
            };

            db.Books.Add(newBook);
            try
            {
                await db.SaveChangesAsync();
                return Ok(newBook);
            }
            catch { return StatusCode(500); }
        }

        [HttpDelete]
        public async Task<IActionResult> Delete()
        {
            using var db = new AppDbContext();
            try
            {
                db.Books.RemoveRange(db.Books.AsNoTracking().ToList());
                await db.SaveChangesAsync();
                return Ok();
            } catch { return StatusCode(500); }
        }

        [HttpDelete("{title}")]
        public async Task<IActionResult> Delete(string title)
        {
            using var db = new AppDbContext();
            var book = await db.Books.FirstOrDefaultAsync(b => b.Title == title);

            if (book == null)
                return NotFound();

            db.Books.Remove(book);
            await db.SaveChangesAsync();

            return Ok();
        }

    }
}
