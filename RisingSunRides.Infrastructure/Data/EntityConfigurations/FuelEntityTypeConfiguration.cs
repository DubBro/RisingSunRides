namespace RisingSunRides.Infrastructure.Data.EntityConfigurations
{
    public class FuelEntityTypeConfiguration : IEntityTypeConfiguration<Fuel>
    {
        public void Configure(EntityTypeBuilder<Fuel> builder)
        {
            builder.HasKey(f => f.Id);

            builder.Property(f => f.Id)
                .UseIdentityColumn()
                .IsRequired();

            builder.Property(f => f.Name)
                .HasMaxLength(55)
                .IsRequired();
        }
    }
}
