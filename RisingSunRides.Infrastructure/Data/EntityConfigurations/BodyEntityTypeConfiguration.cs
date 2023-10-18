﻿namespace RisingSunRides.Infrastructure.Data.EntityConfigurations
{
    public class BodyEntityTypeConfiguration : IEntityTypeConfiguration<Body>
    {
        public void Configure(EntityTypeBuilder<Body> builder)
        {
            builder.HasKey(b => b.Id);

            builder.Property(b => b.Id)
                .UseHiLo("body_hilo")
                .IsRequired();

            builder.Property(b => b.Name)
                .HasMaxLength(55)
                .IsRequired();
        }
    }
}
