namespace FoodWorld.Core
{
    public class Food
    {
        public int Id { get; set; }

        public int RestaurantID { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int Price { get; set; }

        public Restaurant Restaurant { get; set; }

    }
}
