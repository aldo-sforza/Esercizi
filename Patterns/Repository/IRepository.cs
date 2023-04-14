namespace Patterns.Repository
{
    
    public interface IRepository<T>
        where T : Entity
    {
        void Create(string id);

        T Load(string id);

        void Delete(string id);

        bool Exists(string id);
    }
}