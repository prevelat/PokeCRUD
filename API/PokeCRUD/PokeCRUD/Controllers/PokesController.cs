using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PokeCRUD.Data;
using PokeCRUD.Models.Domain;
using PokeCRUD.Models.DTO;

namespace PokeCRUD.Controllers
{
    // https://localhost:xxx/api/pokes
    [Route("api/[controller]")]
    [ApiController]
    public class PokesController : ControllerBase
    {
        private readonly ApplicationDbContext dbContext;

        public PokesController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        //
        [HttpPost]
        public async Task<IActionResult> CreatePoke(CreatePokeRequestDTO request){
            // Map DTO to Poke model
            var poke = new Poke{
                Name = request.Name,
                Type = request.Type,
                Move = request.Move,
                Weakness = request.Weakness,
                Level = request.Level
            };

            await dbContext.Pokes.AddAsync(poke);
            await dbContext.SaveChangesAsync();

            //Map Model to DTO
            var response = new PokeDTO{
                Id = poke.Id,
                Name = poke.Name,
                Type = poke.Type,
                Move = poke.Move,
                Weakness = poke.Weakness,
                Level = poke.Level,
                BirthDate = poke.BirthDate,
            };
            return Ok(response);
        }
    }
}
