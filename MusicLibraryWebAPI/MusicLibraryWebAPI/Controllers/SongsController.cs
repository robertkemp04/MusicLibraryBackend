using Google.Protobuf.Collections;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MusicLibraryWebAPI.Data;
using MusicLibraryWebAPI.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MusicLibraryWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SongsController : ControllerBase
    {
        private readonly ApplicationDbContext db;

        public SongsController(ApplicationDbContext context)
        {
            db = context;
        }

        // GET: api/<MusicsController>
        [HttpGet]
        public IActionResult Get()
        {
            var songs = db.Musics.ToList();
           
            return Ok(songs);
        }

        // GET api/<MusicsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            var song = db.Musics.Find(id);
            db.Musics.ToList();

            return Ok(song);

        }

        // POST api/<MusicsController>
        [HttpPost]
        public IActionResult Post([FromBody] Song songAdd)
        {
            db.Musics.Add(songAdd);
            db.SaveChanges();
            return StatusCode(201, songAdd);
        }

        // PUT api/<MusicsController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Song songData)
        {
           var song = db.Musics.Find(id);
            song.Title = songData.Title;
            song.Artist = songData.Artist;
            song.Album = songData.Album;
            song.ReleaseDate = songData.ReleaseDate;
            song.Genre = songData.Genre;

            db.SaveChanges();

            return Ok(song);
        }

        // DELETE api/<MusicsController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var song = db.Musics.Find(id);
            db.Musics.ExecuteDelete();
            db.SaveChanges();
            return NoContent();
        }
    }
}
