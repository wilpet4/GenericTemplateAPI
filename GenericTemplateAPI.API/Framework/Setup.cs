using GenericTemplateAPI.API.Context;

namespace GenericTemplateAPI.API.Framework
{
    public class Setup
    {
        protected readonly DatabaseContext _context;

        public Setup(DatabaseContext context)
        {
            _context = context;
        }

        public void SetupDatabase()
        {
            _context.Database.EnsureDeleted();
            _context.Database.EnsureCreated();

            DataSeeder.Seed(_context);
        }
    }
}
