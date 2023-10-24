namespace RisingSunRides.Application
{
    public interface IApplicationDbContext
    {
        DbSet<Body> Bodies { get; set; }
        DbSet<Condition> Conditions { get; set; }
        DbSet<Drivetrain> Drivetrains { get; set; }
        DbSet<Fuel> Fuels { get; set; }
        DbSet<Transmission> Transmissions { get; set; }
        DbSet<Make> Makes { get; set; }
        DbSet<Model> Models { get; set; }
        DbSet<Car> Cars { get; set; }
        DbSet<Advertisement> Advertisements { get; set; }
        DbSet<User> Users { get; set; }
        DbSet<UserFavAdvertisement> UserFavAdvertisements { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
