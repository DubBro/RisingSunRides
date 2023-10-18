namespace RisingSunRides.Infrastructure.Data.EntityConfigurations
{
    public class MakeEntityTypeConfiguration : IEntityTypeConfiguration<Make>
    {
        public void Configure(EntityTypeBuilder<Make> builder)
        {
            builder.HasKey(m => m.Id);

            builder.Property(m => m.Id)
                .UseHiLo("make_hilo")
                .IsRequired();

            builder.Property(m => m.Name)
                .HasMaxLength(55)
                .IsRequired();
        }
    }
}
