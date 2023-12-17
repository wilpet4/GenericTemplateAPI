using GenericTemplateAPI.API.Entities.Base;

namespace GenericTemplateAPI.API.Entities
{
    public class Evolution : Entity
    {
        public int Id { get; set; }
        public int Level { get; set; }
        public Pokemon? Pokemon { get; set; }
    }
}
