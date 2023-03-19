namespace Patterns.Repository
{
    public interface IUnitOfWork
    {
        void SaveChanges();
    }
}