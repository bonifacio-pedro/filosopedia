using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace FilosoPediaWeb.Api.Models;
public class Book
{
    [Key]
    public long BookId { get; set; }
    [Required]
    public string? Title { get; set; }
    [Required]
    public string? Description { get; set; }
    [Required]
    public string? ImageBookUrl { get; set; }
    [Required]
    public ushort Stars { get; set; }

    // Foreign key
    
    public ICollection<Comentary>? Comentaries { get; set; }
    [Required]
    public long GenderId { get; set; }
    [JsonIgnore]
    public Gender? Gender { get; set; }
    [Required]
    public long AuthorId { get; set; }
    [JsonIgnore]
    public Author? Author { get; set; } 
}
