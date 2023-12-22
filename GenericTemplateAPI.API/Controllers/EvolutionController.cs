using GenericTemplateAPI.API.Controllers.Base;
using GenericTemplateAPI.API.Entities;
using GenericTemplateAPI.API.Repository;

namespace GenericTemplateAPI.API.Controllers
{
    public class EvolutionController : ApiController<Evolution, int>
    {
        public EvolutionController(Repository<Evolution, int> repository) : base(repository) { }
    }
}
