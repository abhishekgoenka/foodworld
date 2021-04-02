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

            // seed restaurant data
            modelBuilder.Entity<Restaurant>().HasData(new Restaurant { Id = 1, Name = "Pall Mall Restaurant", Location = "London", Cuisine = CuisineType.Italian });
            modelBuilder.Entity<Restaurant>().HasData(new Restaurant { Id = 2, Name = "Indian Coffee House", Location = "India", Cuisine = CuisineType.Indian });
            modelBuilder.Entity<Restaurant>().HasData(new Restaurant { Id = 3, Name = "Boston Pizza", Location = "Mexico", Cuisine = CuisineType.Mexican });

            // seed food data
            modelBuilder.Entity<Food>().HasData(new Food { Id = 1, RestaurantID = 1, Name = "Chicken pot pie", Description = "Chicken pot pie", Price = 2 });
            modelBuilder.Entity<Food>().HasData(new Food { Id = 2, RestaurantID = 2, Name = "Gajar Halwa", Description = "Carrot pudding, made by cooking fresh grated carrots along with sugar, milk and ghee", Price = 5 });
            modelBuilder.Entity<Food>().HasData(new Food { Id = 3, RestaurantID = 2, Name = "Besan Halwa", Description = "Besan is hindi name for chickpea flour. This pudding is made by cooking chickpea flour in a rich sugar syrup ", Price = 4 });
            modelBuilder.Entity<Food>().HasData(new Food { Id = 4, RestaurantID = 2, Name = "Barfi", Description = "Barfi is essentially a more solidified form of a milk-based pudding. In this dish, a sweet batter is thickened and then set to cool and cut into smaller pieces ", Price = 25 });
            modelBuilder.Entity<Food>().HasData(new Food { Id = 5, RestaurantID = 2, Name = "Saag Paneer", Description = "Saag is simply the hindi name for leafy green vegetables. But this particular dish refers to a delicious curry where spinach is cooked with spices and then paneer is added to the dish ", Price = 11 });
            modelBuilder.Entity<Food>().HasData(new Food { Id = 6, RestaurantID = 2, Name = "Vada Pav", Description = "Vadas are deep fried dumplings or flattened patties of potato, and a pav is a plain old dinner roll. Vada pav is essentially a spicier vegetarian version of sliders where the dumpling or patty is sandwiched between two halves of a dinner roll. ", Price = 22 });
            modelBuilder.Entity<Food>().HasData(new Food { Id = 7, RestaurantID = 2, Name = "Naan", Description = "Naan is one of the most popular Indian flatbreads. To make a naan, wheat flour dough is prepared either by allowing it to rise using yeast, or by the addition of yogurt to the dough. ", Price = 7 });
            modelBuilder.Entity<Food>().HasData(new Food { Id = 8, RestaurantID = 2, Name = "Tikka Masala", Description = "Tikka is the Hindi term for “small chunks,” and masala means a spice blend. So when small chunks of anything, like chicken, are cooked in a sauce with a particular spice blend, it is called Chicken Tikka Masala. ", Price = 8 });
            modelBuilder.Entity<Food>().HasData(new Food { Id = 9, RestaurantID = 3, Name = "VEG PIZZA", Description = "A delight for veggie lovers! Choose from our wide range of delicious vegetarian pizzas, it's softer and tastier ", Price = 5 });
            modelBuilder.Entity<Food>().HasData(new Food { Id = 10, RestaurantID = 3, Name = "PIZZA MANIA", Description = "Tomato | Grilled Mushroom |Jalapeno |Golden Corn | Beans in a fresh pan crust", Price = 18 });
            modelBuilder.Entity<Food>().HasData(new Food { Id = 11, RestaurantID = 3, Name = "BURGER PIZZA- PREMIUM VEG", Description = "The good just got better! Treat yourself to the premium taste of the Burger Pizza, that looks good and tastes great with paneer and red paprika. ", Price = 16 });
        }

        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<Food> Foods { get; set; }
    }
}
