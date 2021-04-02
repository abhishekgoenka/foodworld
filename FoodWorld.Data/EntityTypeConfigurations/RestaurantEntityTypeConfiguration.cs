using FoodWorld.Core;
using Microsoft.EntityFrameworkCore;

namespace FoodWorld.Data.EntityTypeConfigurations
{
    public class RestaurantEntityTypeConfiguration : IEntityTypeConfiguration<Restaurant>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Restaurant> builder)
        {
            builder.ToTable("Restaurants");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.Name).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Location).IsRequired().HasMaxLength(255);
        }
    }
}
