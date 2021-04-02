using FoodWorld.Core;
using FoodWorld.Data;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace FoodWorld.Web.Pages.Foods
{
    public class ListModel : PageModel
    {
        private readonly IFoodData foodData;

        public IEnumerable<Food> Foods { get; set; }

        public ListModel(IFoodData foodData)
        {
            this.foodData = foodData;
        }

        public void OnGet(int restaurantId)
        {
            Foods = this.foodData.GeFoodBytRestaurantID(restaurantId);
        }
    }
}
