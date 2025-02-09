using Microsoft.EntityFrameworkCore;
using MusicAPI.Models;

namespace MusicAPI;

public class MusicApiContext : DbContext
{
    public MusicApiContext(DbContextOptions<MusicApiContext> options) : base(options) { }

    public DbSet<Artist> Artists { get; set; }
    public DbSet<Album> Albums { get; set; }
    public DbSet<Song> Songs { get; set; }
}