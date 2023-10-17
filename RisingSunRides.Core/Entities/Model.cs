namespace RisingSunRides.Core.Entities
{
    public class Model : EntityBase
    {
        public int MakeId { get; set; }
        public Make Make { get; set; } = null!;

        public Car Car { get; set; } = null!;
    }
}
