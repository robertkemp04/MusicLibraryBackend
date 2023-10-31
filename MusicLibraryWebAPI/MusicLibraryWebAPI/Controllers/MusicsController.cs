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
        private readonly ApplicationDbContext _context;

        public MusicsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/<MusicsController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            var musics = _context.Musics.ToList();
           
            return new string[] { "value1", "value2" };
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
            _context.Musics.Add(music);
            _context.SaveChanges();
            return StatusCode(201, music);
        }

        // PUT api/<MusicsController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Music music)
        {
            _context.Musics.Update(music);
            _context.SaveChanges();
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
