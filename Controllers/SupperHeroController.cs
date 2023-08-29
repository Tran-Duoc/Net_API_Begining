using Microsoft.AspNetCore.Mvc;
using SupperHeroAPI.Models;

namespace SupperHeroAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SupperHeroController : ControllerBase
    {

         public static List<SupperHero> supperheros = new List<SupperHero> {
                new SupperHero {
                    Id = 1,
                    FirstName = "Tran",
                    LastName = "Duoc",
                    Name = "Tran Minh Duoc",
                    Place = "Viet Nam"
                },
                new SupperHero {
                    Id = 2,
                    FirstName = "Minh",
                    LastName = "Thu",
                    Name = "Minh Thu",
                    Place = "Viet Nam"
                }
            };


        [HttpGet]
        public async Task<ActionResult<List<SupperHero>>> GetAllHero()
        {
            return Ok(supperheros);

        }

        [HttpGet("{id}")]
        public async Task<ActionResult<List<SupperHero>>> GetSignleHero (int id)
        {
            var hero = supperheros.Find(x => x.Id == id);
            if(hero == null)
            {
                return BadRequest("Item not found");

            }
            return Ok(hero);
        }
        [HttpPost]
        public async Task<ActionResult<List<SupperHero>>> AddHero (SupperHero hero)
        {
            supperheros.Add(hero);
            return Ok(supperheros); 
        }

    }
}
