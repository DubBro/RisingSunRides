namespace RisingSunRides.Infrastructure.Data.EntityConfigurations
{
    public class CarEntityTypeConfiguration : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id)
                .UseHiLo("car_hilo")
                .IsRequired();

            builder.Property(c => c.VIN)
                .HasMaxLength(17)
                .IsFixedLength()
                .IsRequired();

            builder.Property(c => c.Year)
                .IsRequired();

            builder.HasOne(c => c.Model)
                .WithOne(m => m.Car)
                .HasForeignKey<Car>(c => c.ModelId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(c => c.Body)
                .WithOne(b => b.Car)
                .HasForeignKey<Car>(c => c.BodyId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(c => c.Transmission)
                .WithOne(t => t.Car)
                .HasForeignKey<Car>(c => c.TransmissionId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(c => c.Fuel)
                .WithOne(f => f.Car)
                .HasForeignKey<Car>(c => c.FuelId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(c => c.Drivetrain)
                .WithOne(d => d.Car)
                .HasForeignKey<Car>(c => c.DrivetrainId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(c => c.Condition)
                .WithOne(cnd => cnd.Car)
                .HasForeignKey<Car>(c => c.ConditionId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
