using Collections;
using System;

namespace Console.Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Using collections");
            OutputForCollection();
        }



        private static void OutputForCollection()
        {
            var random = new Random();
            var numbers = new List<int>();

            for (int i = random.Next(5, 10); i > 0; i--)
            {
                numbers.Add(random.Next(100));
            }

            System.Console.WriteLine("Lista di numeri:");
            foreach (int i in numbers)
            {
                System.Console.WriteLine(i);
            }

            System.Console.WriteLine("Numeri Pari:");
            foreach (int n in Collection.GetEvenNumbersLinq(numbers))
            {
                System.Console.WriteLine(n);
            }

            System.Console.WriteLine("Numero massimo:");
            System.Console.WriteLine(Collection.GetMax(numbers));

            System.Console.WriteLine("Numeri con indice dispari");
            foreach (int n in Collection.GetOddIndexNumbers(numbers))
            {
                System.Console.WriteLine(n);
            }

            System.Console.WriteLine("Lista di numeri invertita");
            foreach (int n in Collection.GetInvertedList(numbers))
            {
                System.Console.WriteLine(n);
            }
        }
    }
}