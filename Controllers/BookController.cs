using AutoMapper;
using FilosoPediaWeb.Api.Context;
using FilosoPediaWeb.Api.Models;
using FIlosoPediaWeb.Api.Mapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FilosoPediaWeb.Api.Controllers;

[ApiController]
[Route("/api/[controller]")]
public class BookController: ControllerBase
{
    private readonly AppDbContext _con;
    private readonly IMapper _mapper;
    public BookController(AppDbContext con, IMapper mapper)
    {
        _con = con;
        _mapper = mapper;
    }

    [HttpGet]
    public async Task<IActionResult> GetAllBooks () {
        var books = await _con.Books
                              .AsNoTracking()
                              .ToListAsync();

        return Ok(_mapper.Map<IEnumerable<BookDTO>>(books));
    }

    [HttpGet("{id:long}")]
    public async Task<ActionResult<Book>> GetOneBook ([FromRoute] long id) {
        var book = await _con.Books.FindAsync(id);
        if (book is null) return NotFound("Livro não encontrado");
        
        return Ok(_mapper.Map<BookDTO>(book));
    }

    [HttpPost]
    public async Task<IActionResult> PostBook ([FromBody] Book book) {
        if (book is null) return BadRequest();

        // VERIFY
        if (await _con.Genders.FindAsync(book.GenderId) is null) return BadRequest("Gênero inexistente");
        if (await _con.Authors.FindAsync(book.AuthorId) is null) return BadRequest("Autor inexistente");

        _con.Books.Add(book);
        await _con.SaveChangesAsync();

        return Ok(_mapper.Map<BookDTO>(book));
    }

    [HttpPut("{id:long}")]
    public async Task<ActionResult<BookDTO>> PutBook([FromRoute] long id, [FromBody] BookDTO book) {
        var bookFind = await _con.Books.FindAsync(id);
        
        if (book is null ||
         id != book?.BookId || 
         bookFind is null) return BadRequest("Não encontramos este livro, por favor verifique o corpo e os parâmetros da requisição");
        
        bookFind.Title = book.Title;
        bookFind.Description = book.Description;
        bookFind.ImageBookUrl = book.ImageBookUrl;
        bookFind.Stars = book.Stars;
        bookFind.GenderId = book.GenderId;
        bookFind.AuthorId = book.AuthorId;

        _con.Books.Update(bookFind);
        await _con.SaveChangesAsync();

        return Ok(_mapper.Map<BookDTO>(bookFind));
    }

    [HttpDelete("{id:long}")]
    public async Task<ActionResult> DeleteBook ([FromRoute] long id) {
        var book = await _con.Books.FindAsync(id);

        if (book is null) return BadRequest("Livro inexistente");

        _con.Books.Remove(book);
        await _con.SaveChangesAsync();

        return NoContent();
    }
}
