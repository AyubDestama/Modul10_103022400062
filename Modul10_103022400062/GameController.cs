using Microsoft.AspNetCore.Mvc;

namespace Modul10_103022400062
{
    [Route("api/[controller]")]
    [ApiController]
    public class GameController : ControllerBase
    {
        // List statis untuk menyimpan data default
        private static List<Game> _listGame = new List<Game>
        {
           new Game (1, "Valorant", "Riot Games", 2020, "FPS",8.5, ["PC"], ["Multiplayer"], true, 0),
           new Game (2, "GTA V", "Rockstar Games", 2013, "Open World",8.5, ["PC","PS4","PS5","XBOX"], ["Single Player","Multiplayer"], false, 2500000),
           new Game (2, "The Witcher 3", "CD Projekt Red", 2015, "RPG",8.5, ["PC","PS4","PS5","XBOX","Switch"], ["Single Player"], false, 2500000),
        };
      // GET: api/Film
        [HttpGet]
        public IEnumerable<Game> Get()
        {
            return _listGame;
        }
        //GET /api/Film/{index}: Mengembalikan film berdasarkan index
        [HttpGet("{index}")]
        public ActionResult<Game> Get(int index)
        {
            if (index < 0 || index >= _listGame.Count)
                return NotFound();

            return _listGame[index];
        }

        //POST /api/Film: Menambahkan objek Film baru
        [HttpPost]
        public void Post([FromBody] Game newFilm)
        {
            _listGame.Add(newFilm);
        }

        //DELETE /api/Film/{index}: Menghapus objek Film berdasarkan index
        [HttpDelete("{index}")]
        public void Delete(int index)
        {
            if (index >= 0 && index < _listGame.Count)
            {
                _listGame.RemoveAt(index);
            }
        }
    }
}
