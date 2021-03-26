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

        public DbSet<Restaurant> Restaurants { get; set; }
    }
}
