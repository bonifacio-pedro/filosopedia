using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace FilosoPediaWeb.Api.Models;
public class Comentary
{
    [Key]
    public long ComentaryId { get; set; }
    [Required]
    public string? Title { get; set; }
    [Required]
    public string? Body { get; set; }

    // Foreign key
    [Required]
    public long BookId { get; set; }
    [JsonIgnore]
    public Book? Book { get; set; }
}
