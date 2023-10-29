using Microsoft.EntityFrameworkCore;
using MusicLibraryWebAPI.Models;

namespace MusicLibraryWebAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Music> Musics { get; set; }
        public ApplicationDbContext(DbContextOptions
            options) : base(options)
        {

        }
    }
}
