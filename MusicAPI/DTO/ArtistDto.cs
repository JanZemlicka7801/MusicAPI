using MusicAPI.Models;

namespace MusicAPI.DTO;

public class ArtistDto
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public int Age { get; set; }
    public List<string>? AlbumTitles { get; set; }
}