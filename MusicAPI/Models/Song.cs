using System.ComponentModel.DataAnnotations;

namespace MusicAPI.Models;

public class Song
{
    [Key]
    public int Id { get; set; }
    
    [Required]
    [MaxLength(200)]
    public string? Title { get; set; }
    
    [Required]
    public int AlbumId { get; set; }
    public Album? Album { get; set; }
}