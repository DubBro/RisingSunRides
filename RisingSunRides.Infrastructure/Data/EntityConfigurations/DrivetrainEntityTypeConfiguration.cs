namespace RisingSunRides.Infrastructure.Data.EntityConfigurations
{
    public class DrivetrainEntityTypeConfiguration : IEntityTypeConfiguration<Drivetrain>
    {
        public void Configure(EntityTypeBuilder<Drivetrain> builder)
        {
            builder.ToTable(nameof(Drivetrain));

            builder.HasKey(d => d.Id);

            builder.Property(d => d.Id)
                .UseIdentityColumn()
                .IsRequired();

            builder.Property(d => d.Name)
                .HasMaxLength(55)
                .IsRequired();
        }
    }
}
