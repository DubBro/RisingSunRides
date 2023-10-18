namespace RisingSunRides.Infrastructure.Data.EntityConfigurations
{
    public class UserEntityTypeConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(u => u.Id);

            builder.Property(u => u.Id)
                .UseHiLo("user_hilo")
                .IsRequired();

            builder.Property(u => u.Name)
                .HasMaxLength(255)
                .IsRequired();

            builder.Property(u => u.Phone)
                .HasMaxLength(10)
                .IsFixedLength()
                .IsRequired();

            builder.HasIndex(u => u.Phone)
                .IsUnique();

            builder.Property(u => u.Email)
                .HasMaxLength(255)
                .IsRequired(false);

            builder.HasIndex(u => u.Email)
                .IsUnique();

            builder.Property(u => u.Password)
                .HasMaxLength(255)
                .IsRequired();
        }
    }
}
