
using Microsoft.EntityFrameworkCore;
using SuperHeroApi2.Entities;

namespace SuperHeroApi2.Data

{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext>options) : base(options)
        {
            
        }
        public DbSet<SuperHero> SuperHeroes { get; set; }
    }
}
