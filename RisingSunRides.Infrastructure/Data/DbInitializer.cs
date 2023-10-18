namespace RisingSunRides.Infrastructure.Data
{
    public static class DbInitializer
    {
        public static async Task Initialize(ApplicationDbContext dbContext)
        {
            await dbContext.Database.EnsureCreatedAsync();

            if (!dbContext.Bodies.Any())
            {
                await dbContext.Bodies.AddRangeAsync(GetPreconfiguredBodies());
                await dbContext.SaveChangesAsync();
            }

            if (!dbContext.Conditions.Any())
            {
                await dbContext.Conditions.AddRangeAsync(GetPreconfiguredConditions());
                await dbContext.SaveChangesAsync();
            }

            if (!dbContext.Drivetrains.Any())
            {
                await dbContext.Drivetrains.AddRangeAsync(GetPreconfiguredDrivetrains());
                await dbContext.SaveChangesAsync();
            }

            if (!dbContext.Fuels.Any())
            {
                await dbContext.Fuels.AddRangeAsync(GetPreconfiguredFuels());
                await dbContext.SaveChangesAsync();
            }

            if (!dbContext.Makes.Any())
            {
                await dbContext.Makes.AddRangeAsync(GetPreconfiguredMakes());
                await dbContext.SaveChangesAsync();
            }

            if (!dbContext.Models.Any())
            {
                await dbContext.Models.AddRangeAsync(GetPreconfiguredModels());
                await dbContext.SaveChangesAsync();
            }

            if (!dbContext.Transmissions.Any())
            {
                await dbContext.Transmissions.AddRangeAsync(GetPreconfiguredTransmissions());
                await dbContext.SaveChangesAsync();
            }

            if (!dbContext.Users.Any())
            {
                await dbContext.Users.AddRangeAsync(GetPreconfiguredUsers());
                await dbContext.SaveChangesAsync();
            }

            if (!dbContext.Cars.Any())
            {
                await dbContext.Cars.AddRangeAsync(GetPreconfiguredCars());
                await dbContext.SaveChangesAsync();
            }

            if (!dbContext.Advertisements.Any())
            {
                await dbContext.Advertisements.AddRangeAsync(GetPreconfiguredAdvertisements());
                await dbContext.SaveChangesAsync();
            }

            if (!dbContext.UserFavAdvertisements.Any())
            {
                await dbContext.UserFavAdvertisements.AddRangeAsync(GetPreconfiguredUserFavAdvertisements());
                await dbContext.SaveChangesAsync();
            }
        }

        private static IEnumerable<Body> GetPreconfiguredBodies()
        {
            return new List<Body>()
            {
                new Body() { Name = "Coupe" },
                new Body() { Name = "Sedan" },
                new Body() { Name = "Wagon" },
                new Body() { Name = "Hatchback" },
                new Body() { Name = "SUV" },
            };
        }

        private static IEnumerable<Condition> GetPreconfiguredConditions()
        {
            return new List<Condition>()
            {
                new Condition() { Name = "New" },
                new Condition() { Name = "As new" },
                new Condition() { Name = "Used" },
                new Condition() { Name = "Not on the go/For parts" },
            };
        }

        private static IEnumerable<Drivetrain> GetPreconfiguredDrivetrains()
        {
            return new List<Drivetrain>()
            {
                new Drivetrain() { Name = "All Wheel Drive" },
                new Drivetrain() { Name = "Front Wheel Drive" },
                new Drivetrain() { Name = "Rear Wheel Drive" },
            };
        }

        private static IEnumerable<Fuel> GetPreconfiguredFuels()
        {
            return new List<Fuel>()
            {
                new Fuel() { Name = "Gasoline" },
                new Fuel() { Name = "Gas" },
                new Fuel() { Name = "Gas/Gasoline" },
                new Fuel() { Name = "Electric" },
                new Fuel() { Name = "Hybrid" },
                new Fuel() { Name = "Diesel" },
            };
        }

        private static IEnumerable<Make> GetPreconfiguredMakes()
        {
            return new List<Make>()
            {
                new Make() { Name = "Mazda" },
                new Make() { Name = "Nissan" },
                new Make() { Name = "Honda" },
                new Make() { Name = "Toyota" },
                new Make() { Name = "Audi" },
            };
        }

        private static IEnumerable<Model> GetPreconfiguredModels()
        {
            return new List<Model>()
            {
                new Model() { MakeId = 1, Name = "RX-7" },
                new Model() { MakeId = 1, Name = "RX-8" },
                new Model() { MakeId = 2, Name = "Silvia" },
                new Model() { MakeId = 2, Name = "Skyline" },
                new Model() { MakeId = 2, Name = "350Z" },
                new Model() { MakeId = 2, Name = "370Z" },
                new Model() { MakeId = 2, Name = "GT-R" },
                new Model() { MakeId = 3, Name = "Civic" },
                new Model() { MakeId = 3, Name = "Accord" },
                new Model() { MakeId = 3, Name = "S2000" },
                new Model() { MakeId = 3, Name = "NSX" },
                new Model() { MakeId = 4, Name = "Supra" },
                new Model() { MakeId = 4, Name = "Chaser" },
                new Model() { MakeId = 4, Name = "Mark II" },
                new Model() { MakeId = 5, Name = "R8" },
                new Model() { MakeId = 5, Name = "TT" },
                new Model() { MakeId = 5, Name = "A6" },
                new Model() { MakeId = 5, Name = "RS6" },
                new Model() { MakeId = 5, Name = "S6" },
            };
        }

        private static IEnumerable<Transmission> GetPreconfiguredTransmissions()
        {
            return new List<Transmission>()
            {
                new Transmission() { Name = "Manual" },
                new Transmission() { Name = "Automatic" },
                new Transmission() { Name = "Automanual" },
            };
        }

        private static IEnumerable<User> GetPreconfiguredUsers()
        {
            return new List<User>()
            {
                new User() { Name = "ADMIN", Phone = "1111111111", Password = "ADM1N1STRAT1ON", Email = "risingsunrides@gmail.com" },
                new User() { Name = "Taras", Phone = "0987654321", Password = "p@ssw0rD!" },
                new User() { Name = "Vova", Phone = "0999999999", Password = "12345678" },
            };
        }

        private static IEnumerable<Car> GetPreconfiguredCars()
        {
            return new List<Car>()
            {
                new Car()
                {
                    VIN = "AWE123456GTS55555",
                    Year = 2000,
                    ModelId = 1,
                    BodyId = 1,
                    TransmissionId = 1,
                    FuelId = 1,
                    DrivetrainId = 3,
                    ConditionId = 1,
                },
                new Car()
                {
                    VIN = "12345678912345678",
                    Year = 2002,
                    ModelId = 3,
                    BodyId = 1,
                    TransmissionId = 1,
                    FuelId = 1,
                    DrivetrainId = 3,
                    ConditionId = 2,
                },
                new Car()
                {
                    VIN = "WUAZZZ4G2JN903301",
                    Year = 2018,
                    ModelId = 18,
                    BodyId = 3,
                    TransmissionId = 2,
                    FuelId = 1,
                    DrivetrainId = 1,
                    ConditionId = 2,
                },
            };
        }

        private static IEnumerable<Advertisement> GetPreconfiguredAdvertisements()
        {
            return new List<Advertisement>()
            {
                new Advertisement()
                {
                    Price = 50000,
                    City = "Lviv",
                    CreatedOnDate = DateTime.UtcNow,
                    LastModifiedOnDate = DateTime.UtcNow,
                    UserId = 2,
                    CarId = 1,
                },
                new Advertisement()
                {
                    Price = 40000,
                    City = "Kyiv",
                    CreatedOnDate = DateTime.UtcNow,
                    LastModifiedOnDate = DateTime.UtcNow,
                    UserId = 2,
                    CarId = 2,
                },
                new Advertisement()
                {
                    Price = 74000,
                    City = "Kyiv",
                    CreatedOnDate = DateTime.UtcNow,
                    LastModifiedOnDate = DateTime.UtcNow,
                    UserId = 2,
                    CarId = 3,
                },
            };
        }

        private static IEnumerable<UserFavAdvertisement> GetPreconfiguredUserFavAdvertisements()
        {
            return new List<UserFavAdvertisement>()
            {
                new UserFavAdvertisement() { UserId = 3, AdvertisementId = 2 },
                new UserFavAdvertisement() { UserId = 3, AdvertisementId = 3 },
            };
        }
    }
}
