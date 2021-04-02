using FoodWorld.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FoodWorld.Data.EntityTypeConfigurations
{
    public class FoodEntityTypeConfiguration : IEntityTypeConfiguration<Food>
    {
        public void Configure(EntityTypeBuilder<Food> builder)
        {
            builder.ToTable("Foods");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.Name).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Description).IsRequired().HasMaxLength(255);
            builder.Property(x => x.Price).IsRequired();

            builder.HasOne(x => x.Restaurant).WithMany(x => x.Foods).HasForeignKey(x => x.RestaurantID);
        }
    }
}
