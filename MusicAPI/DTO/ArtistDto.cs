using MusicAPI.Models;

namespace MusicAPI.DTO;

public class ArtistDto
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public int Age { get; set; }
    public int AlbumCount { get; set; }
}