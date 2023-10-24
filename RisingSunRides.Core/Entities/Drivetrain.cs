namespace RisingSunRides.Core.Entities
{
    public class Drivetrain : EntityBase
    {
        public IList<Car> Cars { get; set; } = new List<Car>();
    }
}
