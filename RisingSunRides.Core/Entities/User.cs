namespace RisingSunRides.Core.Entities
{
    public class User : EntityBase
    {
        public string Phone { get; set; } = null!;
        public string? Email { get; set; }
        public string Password { get; set; } = null!;

        public IList<UserFavAdvertisement> FavouriteAdvertisements { get; set; } = new List<UserFavAdvertisement>();

        public IList<Advertisement> Advertisements { get; set; } = new List<Advertisement>();
    }
}
