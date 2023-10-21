namespace RisingSunRides.Infrastructure.Data.EntityConfigurations
{
    public class MakeEntityTypeConfiguration : IEntityTypeConfiguration<Make>
    {
        public void Configure(EntityTypeBuilder<Make> builder)
        {
            builder.ToTable(nameof(Make));

            builder.HasKey(m => m.Id);

            builder.Property(m => m.Id)
                .UseIdentityColumn()
                .IsRequired();

            builder.Property(m => m.Name)
                .HasMaxLength(55)
                .IsRequired();
        }
    }
}
