namespace RisingSunRides.Core.Entities
{
    public class UserFavAdvertisement
    {
        public int UserId { get; set; }
        public User User { get; set; } = null!;

        public int AdvertisementId { get; set; }
        public Advertisement Advertisement { get; set; } = null!;
    }
}
