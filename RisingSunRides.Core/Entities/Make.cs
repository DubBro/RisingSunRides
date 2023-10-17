namespace RisingSunRides.Core.Entities
{
    public class Make : EntityBase
    {
        public IList<Model> Models { get; set; } = new List<Model>();
    }
}
