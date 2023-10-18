namespace RisingSunRides.Infrastructure.Data.EntityConfigurations
{
    public class ConditionEntityTypeConfiguration : IEntityTypeConfiguration<Condition>
    {
        public void Configure(EntityTypeBuilder<Condition> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id)
                .UseIdentityColumn()
                .IsRequired();

            builder.Property(c => c.Name)
                .HasMaxLength(55)
                .IsRequired();
        }
    }
}
