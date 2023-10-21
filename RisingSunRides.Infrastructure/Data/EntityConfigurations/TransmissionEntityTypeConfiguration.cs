namespace RisingSunRides.Infrastructure.Data.EntityConfigurations
{
    public class TransmissionEntityTypeConfiguration : IEntityTypeConfiguration<Transmission>
    {
        public void Configure(EntityTypeBuilder<Transmission> builder)
        {
            builder.ToTable(nameof(Transmission));

            builder.HasKey(t => t.Id);

            builder.Property(t => t.Id)
                .UseIdentityColumn()
                .IsRequired();

            builder.Property(t => t.Name)
                .HasMaxLength(55)
                .IsRequired();
        }
    }
}
