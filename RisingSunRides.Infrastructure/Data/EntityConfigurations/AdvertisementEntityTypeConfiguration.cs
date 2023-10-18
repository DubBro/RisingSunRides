﻿namespace RisingSunRides.Infrastructure.Data.EntityConfigurations
{
    public class AdvertisementEntityTypeConfiguration : IEntityTypeConfiguration<Advertisement>
    {
        public void Configure(EntityTypeBuilder<Advertisement> builder)
        {
            builder.HasKey(a => a.Id);

            builder.Property(a => a.Id)
                .UseHiLo("advertisement_hilo")
                .IsRequired();

            builder.Property(a => a.Description)
                .HasMaxLength(1000)
                .IsRequired(false);

            builder.Property(a => a.Price)
                .HasColumnType("decimal")
                .IsRequired();

            builder.Property(a => a.City)
                .HasMaxLength(55)
                .IsRequired();

            builder.Property(a => a.CreatedOnDate)
                .IsRequired();

            builder.Property(a => a.LastModifiedOnDate)
                .IsRequired();

            builder.HasOne(a => a.Owner)
                .WithMany(o => o.Advertisements)
                .HasForeignKey(a => a.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(a => a.Car)
                .WithOne(c => c.Advertisement)
                .HasForeignKey<Advertisement>(a => a.CarId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
