using FoodWorld.Core;
using System.Collections.Generic;
using System.Linq;

namespace FoodWorld.Data
{
    public class SqlFoodData : IFoodData
    {
        private readonly FoodWorldDbContext db;
        public SqlFoodData(FoodWorldDbContext db)
        {
            this.db = db;
        }

        public IEnumerable<Food> GeFoodBytRestaurantID(int id)
        {
            return this.db.Foods.Where(e => e.RestaurantID == id);
        }
    }
}
