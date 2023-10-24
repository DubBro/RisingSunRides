namespace RisingSunRides.Core.Entities
{
    public class Fuel : EntityBase
    {
        public IList<Car> Cars { get; set; } = new List<Car>();
    }
}
