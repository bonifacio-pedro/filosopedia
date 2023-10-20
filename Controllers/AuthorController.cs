using AutoMapper;
using FilosoPediaWeb.Api.Context;
using FilosoPediaWeb.Api.Mapper;
using FilosoPediaWeb.Api.Models;
using FIlosoPediaWeb.Api.Mapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FilosoPediaWeb.Api.Controller;

[ApiController]
[Route("/api/[controller]")]
public class AuthorController: ControllerBase
{
    private readonly AppDbContext _con;
    private readonly IMapper _mapper;
    public AuthorController(AppDbContext con, IMapper mapper)
    {
        _con = con;
        _mapper = mapper;
    }

    [HttpGet]
    public async Task<IActionResult> Get() {
        var authors = await _con.Authors.AsNoTracking().ToListAsync();
        return Ok(_mapper.Map<IEnumerable<AuthorDTO>>(authors));
    }

    /*
    GET BOOKS FROM ONE AUTHOR
    */
    [HttpGet("books/{id:long}")]
    public async Task<ActionResult<IEnumerable<Book>>> GetBooks([FromRoute] long id) {
        var author = await _con.Authors.FindAsync(id);
        
        if (author is null) return NotFound("Autor inexistente");

        var books = await _con.Books
                            .Where(b => b.AuthorId == id)
                            .AsNoTracking()
                            .ToListAsync();

        return Ok(_mapper.Map<IEnumerable<BookDTO>>(books));
    }

    [HttpPost]
    public async Task<IActionResult> PostAuthor ([FromBody] Author author) {
        if (author is null) return BadRequest();

        // Verify
        if (await _con.Genders.FindAsync(author!.GenderId) is null) return NotFound("Gênero inexistente");

        _con.Authors.Add(author);
        await _con.SaveChangesAsync();
        return Ok(_mapper.Map<AuthorDTO>(author));
    }

    [HttpPut("{id:long}")]
    public async Task<ActionResult<AuthorDTO>> PutAuthor ([FromRoute] long id, [FromBody] Author author) {
        var authorSearch = await _con.Authors.FindAsync(id);

        if (authorSearch is null || author is null) return BadRequest();
        if (authorSearch.AuthorId != author.AuthorId) return BadRequest();

        authorSearch.Name = author.Name;
        authorSearch.BirthDay = author.BirthDay;
        authorSearch.Bio = author.Bio;
        authorSearch.GenderId = author.GenderId;

        _con.Authors.Update(author);
        await _con.SaveChangesAsync();
        
        return Ok(_mapper.Map<AuthorDTO>(author));
    }

    [HttpDelete("{id:long}")]
    public async Task<ActionResult> DeleteAuthor([FromRoute] long id) {
        var author = await _con.Authors.FindAsync(id);
        if (author is null) return BadRequest();

        _con.Authors.Remove(author);
        await _con.SaveChangesAsync();

        return NoContent();
    }
}
