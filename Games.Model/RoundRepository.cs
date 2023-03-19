using Patterns.Repository;

namespace Games.Model
{
    public class RoundRepository
        : IRepository<Round>, IUnitOfWork
    {
        public Round Create()
        {
            throw new NotImplementedException();
        }

        public void Delete(string id)
        {
            throw new NotImplementedException();
        }

        public bool Exists(string id)
        {
            throw new NotImplementedException();
        }

        public Round Load(string id)
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}