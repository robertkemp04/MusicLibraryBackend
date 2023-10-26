using Microsoft.Identity.Client;

namespace MusicLibraryWebAPI.Models
{
    public class Music
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Artist { get; set; }
        public string Album { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string genre { get; set; }

    }
}
