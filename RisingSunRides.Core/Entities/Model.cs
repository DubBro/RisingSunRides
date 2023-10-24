namespace RisingSunRides.Core.Entities
{
    public class Model : EntityBase
    {
        public int MakeId { get; set; }
        public Make Make { get; set; } = null!;

        public IList<Car> Cars { get; set; } = new List<Car>();
    }
}
