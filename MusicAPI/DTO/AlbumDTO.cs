﻿using MusicAPI.Models;

namespace MusicAPI.DTO;

public class AlbumDto
{
    public int Id { get; set; }
    public string? Title { get; set; }
    public string? ArtistName { get; set; }
    public int SongCount { get; set; }
}