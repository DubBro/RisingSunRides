namespace RisingSunRides.Infrastructure.Data.EntityConfigurations
{
    public class ModelEntityTypeConfiguration : IEntityTypeConfiguration<Model>
    {
        public void Configure(EntityTypeBuilder<Model> builder)
        {
            builder.HasKey(m => m.Id);

            builder.Property(m => m.Id)
                .UseHiLo("model_hilo")
                .IsRequired();

            builder.Property(m => m.Name)
                .HasMaxLength(55)
                .IsRequired();

            builder.HasOne(mdl => mdl.Make)
                .WithMany(mk => mk.Models)
                .HasForeignKey(mdl => mdl.MakeId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
