using Microsoft.EntityFrameworkCore;
using MusicAPI.Models;

namespace MusicAPI;

public class MusicApiDbContext : DbContext
{
    public MusicApiDbContext(DbContextOptions<MusicApiDbContext> options) : base(options) { }

    public DbSet<Artist> Artists { get; set; }
    public DbSet<Album> Albums { get; set; }
    public DbSet<Song> Songs { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Creates a 1-to-many relationship between Artist and Album
        modelBuilder.Entity<Album>().HasOne(a => a.Artist).WithMany(ar => ar.Albums).HasForeignKey(a => a.ArtistId);
        // Creates a 1-to-many relationship between Album and Song
        modelBuilder.Entity<Song>().HasOne(s => s.Album).WithMany(al => al.Songs).HasForeignKey(s => s.AlbumId);
        
        base.OnModelCreating(modelBuilder);
    }
}