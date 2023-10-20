namespace FilosoPediaWeb.Api.Mapper;
public class AuthorDTO
{
    public long AuthorId { get; set; }
    public string? Name { get; set; }
    public DateTime BirthDay { get; set; }
    public string? Bio { get; set; }
    public long GenderId { get; set; } 
}
