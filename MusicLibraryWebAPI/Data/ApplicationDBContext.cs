using Microsoft.EntityFrameworkCore;

namespace MusicLibraryWebAPI.Data
{
    public class ApplicationDBContext : DbContext    
    {
        public ApplicationDBContext(DbContextOptions
            options) : base(options)
        { 

        }
    }
}
