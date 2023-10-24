namespace RisingSunRides.Infrastructure.Data.EntityConfigurations
{
    public class CarEntityTypeConfiguration : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            builder.ToTable(nameof(Car));

            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id)
                .UseIdentityColumn()
                .IsRequired();

            builder.Property(c => c.VIN)
                .HasMaxLength(17)
                .IsFixedLength()
                .IsRequired();

            builder.HasIndex(u => u.VIN)
                .IsUnique();

            builder.Property(c => c.Year)
                .IsRequired();

            builder.HasOne(c => c.Model)
                .WithMany(m => m.Cars)
                .HasForeignKey(c => c.ModelId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(c => c.Body)
                .WithMany(b => b.Cars)
                .HasForeignKey(c => c.BodyId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(c => c.Transmission)
                .WithMany(t => t.Cars)
                .HasForeignKey(c => c.TransmissionId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(c => c.Fuel)
                .WithMany(f => f.Cars)
                .HasForeignKey(c => c.FuelId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(c => c.Drivetrain)
                .WithMany(d => d.Cars)
                .HasForeignKey(c => c.DrivetrainId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(c => c.Condition)
                .WithMany(cnd => cnd.Cars)
                .HasForeignKey(c => c.ConditionId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
