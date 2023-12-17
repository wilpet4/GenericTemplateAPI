using GenericTemplateAPI.API.Controllers.Base;
using GenericTemplateAPI.API.Entities;
using GenericTemplateAPI.API.Repository;
using Microsoft.AspNetCore.Mvc;

namespace GenericTemplateAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PokemonController : ApiController<Pokemon, int>
    {
        public PokemonController(Repository<Pokemon, int> repository) : base(repository) { }
    }
}
