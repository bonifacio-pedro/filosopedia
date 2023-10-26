using AutoMapper;
using FilosoPediaWeb.Api.Context;
using FilosoPediaWeb.Api.Mapper;
using FilosoPediaWeb.Api.Models;
using FIlosoPediaWeb.Api.Mapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FilosoPediaWeb.Api.Controllers;

[ApiController]
[Route("/api/[controller]")]
public class GenderController: ControllerBase
{
    private readonly AppDbContext _con;
    private readonly IMapper _mapper;
    public GenderController(AppDbContext con, IMapper mapper)
    {
        _con = con;
        _mapper = mapper;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Gender>>> GetGenders() {
        var genders = await _con.Genders
                                .AsNoTracking()
                                .ToListAsync();

        return Ok(_mapper.Map<IEnumerable<GenderDTO>>(genders));
    }

    /*
    ALL AUTHORS FROM ONE GENDER
    */
    [HttpGet("author/{id:long}")]
    public async Task<ActionResult<IEnumerable<AuthorDTO>>> GetAuthorGender([FromRoute] long id) {
        if (await _con.Genders.FindAsync(id) is null) return NotFound("Gênero inexistente");

        var authors = await _con.Authors
                                .Where(b => b.GenderId == id)
                                .AsNoTracking()
                                .ToListAsync();

        return Ok(_mapper.Map<IEnumerable<AuthorDTO>>(authors));
    }

    /*
    ALL BOOKS FROM ONE GENDER
    */
    [HttpGet("books/{id:long}")]
    public async Task<ActionResult<IEnumerable<BookDTO>>> GetBookGender([FromRoute] long id) {
        if (await _con.Genders.FindAsync(id) is null) return NotFound("Gênero inexistenet");

        var books = await _con.Books
                              .Where(b => b.GenderId == id)
                              .AsNoTracking()
                              .ToListAsync();

        return Ok(_mapper.Map<IEnumerable<BookDTO>>(books));
    }

    [HttpPost]
    public async Task<IActionResult> PostGender([FromBody] Gender gender) 
    {
        if (gender is null) return BadRequest("Sem corpo de requisição");

        _con.Genders.Add(gender);
        await _con.SaveChangesAsync();

        return Ok(_mapper.Map<GenderDTO>(gender));
    }

    [HttpPut("{id:long}")]
    public async Task<ActionResult<GenderDTO>> PutGender([FromRoute] long id, [FromBody] GenderDTO gender) {
        if (gender.GenderId != id|| gender is null) return BadRequest();

        _con.Entry(gender).State = EntityState.Modified;
        await _con.SaveChangesAsync();

        return Ok(_mapper.Map<GenderDTO>(gender));
    }   
}
