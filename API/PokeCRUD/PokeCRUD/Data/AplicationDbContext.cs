using PokeCRUD.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace PokeCRUD.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Poke> Pokes { get; set; }
    }
}
