using GenericTemplateAPI.API.Entities.Base;
using System.ComponentModel.DataAnnotations;

namespace GenericTemplateAPI.API.Entities
{
    public class PokemonType : Entity
    {
        [Key]
        public string Name { get; set; }
    }
}