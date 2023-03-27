using Patterns.Repository;

namespace Cars.Model
{
    public class CarRepository : IRepository<Car>,
                                 IUnitOfWork
    {
        private const string FILE_NAME = "cars.txt";
        private readonly Dictionary<string, Car> _items = new Dictionary<string, Car>();

        public void Create(string id)
        {
            var doors = new List<Door>();
            doors.Add(new Door());
            doors.Add(new Door());
            doors.Add(new Door());
            doors.Add(new Door());
            doors.Add(new Door());

            var car = new Car(id,doors);

            _items.Add(car.Id, car);

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

        public void SaveChanges()
        {
            var folder = AppDomain.CurrentDomain.BaseDirectory;
            var fullPath = System.IO.Path.Combine(folder, FILE_NAME);
            var content = System.Text.Json.JsonSerializer.Serialize(_items.Values);
            System.IO.File.WriteAllText(fullPath, content);
        }
    }
}