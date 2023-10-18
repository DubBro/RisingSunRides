namespace RisingSunRides.Infrastructure.Data.EntityConfigurations
{
    public class DrivetrainEntityTypeConfiguration : IEntityTypeConfiguration<Drivetrain>
    {
        public void Configure(EntityTypeBuilder<Drivetrain> builder)
        {
            builder.HasKey(d => d.Id);

            builder.Property(d => d.Id)
                .UseHiLo("drivetrain_hilo")
                .IsRequired();

            builder.Property(d => d.Name)
                .HasMaxLength(55)
                .IsRequired();
        }
    }
}
