namespace RisingSunRides.Core.Entities
{
    public class Condition : EntityBase
    {
        public IList<Car> Cars { get; set; } = new List<Car>();
    }
}
