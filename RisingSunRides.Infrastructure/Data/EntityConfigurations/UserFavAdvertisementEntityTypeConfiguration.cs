namespace RisingSunRides.Infrastructure.Data.EntityConfigurations
{
    public class UserFavAdvertisementEntityTypeConfiguration : IEntityTypeConfiguration<UserFavAdvertisement>
    {
        public void Configure(EntityTypeBuilder<UserFavAdvertisement> builder)
        {
            builder.ToTable(nameof(UserFavAdvertisement));

            builder.HasKey(fv => new { fv.UserId, fv.AdvertisementId });

            builder.HasOne(fv => fv.User)
                .WithMany(u => u.FavouriteAdvertisements)
                .HasForeignKey(fv => fv.UserId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(fv => fv.Advertisement)
                .WithMany(a => a.UserFavourites)
                .HasForeignKey(fv => fv.AdvertisementId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
