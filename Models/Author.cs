using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace FilosoPediaWeb.Api.Models;
public class Author
{
    [Key]
    public long AuthorId { get; set; }
    [Required]
    public string? Name { get; set; }
    [DataType(DataType.Date)]
    public DateTime BirthDay { get; set; }
    [Required]
    public string? Bio { get; set; }

    public ICollection<Book>? Books { get; set; }


    public long GenderId { get; set; }
    [JsonIgnore]
    public Gender? Gender { get; set; }

}
