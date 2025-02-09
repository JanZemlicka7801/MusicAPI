using Microsoft.EntityFrameworkCore;
using MusicAPI.Models;

namespace MusicAPI;

public class MusicApiDbContext : DbContext
{
    public MusicApiDbContext(DbContextOptions<MusicApiDbContext> options) : base(options) { }

    public DbSet<Artist> Artists { get; set; }
    public DbSet<Album> Albums { get; set; }
    public DbSet<Song> Songs { get; set; }
}