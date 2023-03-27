using Cars.Model;

namespace Console.Cars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello, Cars!");
            var carRepository = new CarRepository();
            carRepository.Create("2ssed3");
            
            carRepository.SaveChanges();

            System.Console.ReadLine();
        }
    }
}