using System.ComponentModel.DataAnnotations;

namespace MusicAPI.Models;

public class Artist
{
    [Key]
    public int Id { get; set; }
    
    [Required]
    [MaxLength(100)]
    public string? Name { get; set; }
    
    public int Age { get; set; }
    
    public ICollection<Album>? Albums { get; set; }
}