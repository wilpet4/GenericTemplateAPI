using GenericTemplateAPI.API.Entities.Base;
using System.ComponentModel.DataAnnotations;

namespace GenericTemplateAPI.API.Entities
{
    public class Pokemon : Entity
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public List<PokemonType> PokemonTypes { get; set; }

        public int? EvolutionId { get; set; }
        public Evolution? Evolution { get; set; }
    }
}
