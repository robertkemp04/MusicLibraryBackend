using Google.Protobuf.Collections;
using Microsoft.AspNetCore.Mvc;
using MusicLibraryWebAPI.Data;
using MusicLibraryWebAPI.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MusicLibraryWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MusicsController : ControllerBase
    {
        private readonly ApplicationDbContext db;

        public MusicsController(ApplicationDbContext context)
        {
            db = context;
        }

        // GET: api/<MusicsController>
        [HttpGet]
        public IActionResult Get()
        {
            var musics = db.Musics.ToList();
           
            return Ok(musics);
        }

        // GET api/<MusicsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {

            return "value";
        }

        // POST api/<MusicsController>
        [HttpPost]
        public IActionResult Post([FromBody] Music music)
        {
            db.Musics.Add(music);
            db.SaveChanges();
            return StatusCode(201, music);
        }

        // PUT api/<MusicsController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Music music)
        {
            db.Musics.Update(music);
            db.SaveChanges();
            return StatusCode(200, music);
        }

        // DELETE api/<MusicsController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return NoContent();
        }
    }
}
