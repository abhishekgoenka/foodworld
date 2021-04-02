using FoodWorld.Core;
using System.Collections.Generic;

namespace FoodWorld.Data
{
    public interface IFoodData
    {
        IEnumerable<Food> GeFoodBytRestaurantID(int id);
    }
}
