using FoodWorld.Core;
using Microsoft.EntityFrameworkCore;

namespace FoodWorld.Data
{
    public class FoodWorldDbContext : DbContext
    {
        public FoodWorldDbContext(DbContextOptions<FoodWorldDbContext> options)
            : base(options)
        {

        }

        public DbSet<Restaurant> Restaurants { get; set; }
    }
}
