namespace Patterns.Repository
{
    public class Entity
    {
        public string Id { get; protected set; }

        public Entity()
        {
            Id = Guid.NewGuid().ToString();
        }
    }
}