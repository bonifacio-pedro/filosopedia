
namespace FIlosoPediaWeb.Api.Mapper;
public class BookDTO
{
    public long BookId { get; set; }
    public string? Title { get; set; }
    public string? Description { get; set; }
    public string? ImageBookUrl { get; set; }
    public ushort Stars { get; set; }
    public long GenderId { get; set; }
    public long AuthorId { get; set; }
}
