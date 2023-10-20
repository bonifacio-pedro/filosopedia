using FilosoPediaWeb.Api.Models;

namespace FIlosoPediaWeb.Api.Mapper;
public class ComentaryDTO
{
    public long ComentaryId { get; set; }
    public string? Title { get; set; }
    public string? Body { get; set; }
    public long BookId { get; set; }
    public Book? Book { get; set; }
}
