using Microsoft.EntityFrameworkCore;
using MusicLibraryWebAPI.Models;

namespace MusicLibraryWebAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Song> Musics { get; set; }
        public ApplicationDbContext(DbContextOptions
            options) : base(options)
        {

        }
    }
}
