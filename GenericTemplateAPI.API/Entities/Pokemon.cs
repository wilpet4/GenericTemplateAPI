using GenericTemplateAPI.API.Entities.Base;

namespace GenericTemplateAPI.API.Entities
{
    public class Pokemon : Entity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<PokemonType> PokemonTypes { get; set; }
    }
}
