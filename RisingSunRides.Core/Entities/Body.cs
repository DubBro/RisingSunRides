namespace RisingSunRides.Core.Entities
{
    public class Body : EntityBase
    {
        public IList<Car> Cars { get; set; } = new List<Car>();
    }
}
