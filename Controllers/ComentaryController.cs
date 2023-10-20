using AutoMapper;
using FilosoPediaWeb.Api.Context;
using FilosoPediaWeb.Api.Models;
using FIlosoPediaWeb.Api.Mapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FilosoPediaWeb.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ComentaryController: ControllerBase
{
    private readonly AppDbContext _con;
    private readonly IMapper _mapper;
    public ComentaryController(AppDbContext con, IMapper mapper)
    {
        _con = con;
        _mapper = mapper;
    }

    /*
    GET ALL COMENTARIES FROM ONE BOOK
    */
    [HttpGet("book/{id:long}")]
    public async Task<ActionResult<IEnumerable<Comentary>>> GetComentariesFromBook([FromRoute] long id) {
        var book = await _con.Books.FindAsync(id);
        if (book is null) return BadRequest("Sem corpo de requisição");

        var comentaries = await _con.Comentaries
                                    .Where(c => c.BookId == id)
                                    .AsNoTracking()
                                    .ToListAsync();

        return Ok(_mapper.Map<IEnumerable<ComentaryDTO>>(comentaries));
    }

    /*
    ADD ONE COMENTARY TO ONE BOOK
    */
    [HttpPost]
    public async Task<IActionResult> PostComentary([FromBody] Comentary comentary) {
        if (comentary is null) return BadRequest("Sem corpo de requisição");
        
        if (await _con.Books.FindAsync(comentary.BookId) is null) return NotFound("Livro não existe");

        _con.Comentaries.Add(comentary);
        

        await _con.SaveChangesAsync();
        return Ok(_mapper.Map<ComentaryDTO>(comentary));
    }

    [HttpDelete("{id:long}")]
    public async Task<ActionResult> DeleteComentary([FromRoute] long id) {
        var comentary = await _con.Comentaries.FindAsync(id);
        if (comentary is null) return BadRequest("Comentário não encontrado");

        _con.Comentaries.Remove(comentary);
        await _con.SaveChangesAsync();

        return NoContent();
    }
}
