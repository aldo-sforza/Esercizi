using Patterns.Repository;

namespace Cars.Model
{
    public class CarRepository : IRepository<Car>
    {
        public Car Create()
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

        public Car Load(string id)
        {
            throw new NotImplementedException();
        }
    }
}