using GenericTemplateAPI.API.Controllers.Base;
using GenericTemplateAPI.API.Entities;
using GenericTemplateAPI.API.Repository;
using Microsoft.AspNetCore.Mvc;

namespace GenericTemplateAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PokemonTypeController : ApiController<PokemonType, int>
    {
        public PokemonTypeController(Repository<PokemonType, int> repository) : base(repository) { }
    }
}
