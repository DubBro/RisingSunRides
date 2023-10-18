namespace RisingSunRides.Core.Entities
{
    public class Advertisement : EntityBase
    {
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public string City { get; set; } = null!;
        public DateTime CreatedOnDate { get; set; }
        public DateTime LastModifiedOnDate { get; set; }

        public int UserId { get; set; }
        public User Owner { get; set; } = null!;

        public int CarId { get; set; }
        public Car Car { get; set; } = null!;

        public IList<UserFavAdvertisement> UserFavourites { get; set; } = new List<UserFavAdvertisement>();
    }
}
