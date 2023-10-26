using System.ComponentModel.DataAnnotations;

namespace FilosoPediaWeb.Api.Models;
public class Gender
{
    [Key]
    public long GenderId { get; set; }
    [Required]
    public string? GenderName { get; set; }
    [Required]
    public string? Description { get; set; }
    
    public ICollection<Book>? Books {get; set; }
    public ICollection<Author>? Authors { get; set; }
}
