namespace RisingSunRides.Core.Entities
{
    public class Transmission : EntityBase
    {
        public IList<Car> Cars { get; set; } = new List<Car>();
    }
}
