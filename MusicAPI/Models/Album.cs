using System.ComponentModel.DataAnnotations;

namespace MusicAPI.Models;

public class Album
{
    [Key]
    public int Id { get; set; }
    
    [Required]
    [MaxLength(200)]
    public string? Title { get; set; }
    
    [Required]
    public int ArtistId { get; set; }
    
    public Artist? Artist { get; set; }
    
    public ICollection<Song>? Songs { get; set; }
}