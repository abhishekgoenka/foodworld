using FoodWorld.Core;
using Microsoft.EntityFrameworkCore;

namespace FoodWorld.Data
{
    /// <summary>
    /// FoodWorld DBContext
    /// 
    /// To create new migration script
    ///     dotnet-ef migrations add initialcreate -s ..\FoodWorld.Web\FoodWorld.Web.csproj
    ///  
    /// Apply migrations to DB
    ///     dotnet-ef database update -s ..\FoodWorld.Web\FoodWorld.Web.csproj
    /// </summary>
    public class FoodWorldDbContext : DbContext
    {
        public FoodWorldDbContext(DbContextOptions<FoodWorldDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // add the EntityTypeConfiguration classes
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(FoodWorldDbContext).Assembly);
        }

        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<Food> Foods { get; set; }
    }
}
