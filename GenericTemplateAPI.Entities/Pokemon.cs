using GenericTemplateAPI.Entities.Base;

namespace GenericTemplateAPI.Entities
{
    public class Pokemon : Entity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<PokemonType> PokemonType { get; set; }
    }
}
