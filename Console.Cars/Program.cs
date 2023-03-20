using Cars.Model;

namespace Console.Cars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello, Cars!");
            var carRepository = new CarRepository();
            var car = carRepository.Create();
            
            carRepository.SaveChanges();

            System.Console.ReadLine();
        }
    }
}