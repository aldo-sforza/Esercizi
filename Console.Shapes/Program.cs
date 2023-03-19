using Shapes.Model;

namespace Console.Shapes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Playing with shapes");
            OutputForShape();
        }

        private static void OutputForShape()
        {
            /*
             * dato che mi serve lavorare con più di una figura geometrica
             * invece di creare n variabili di figure geometriche specifiche
             * (leggi Rectangle, Square, Circle)
             * mi costruisco una lista che può contenere il concetto
             * di figura geometrica astratta Shape
             * */
            var shapes = new List<Shape>();

            //grazie al polimorfismo( un rettangolo, un quadrato, un cerchio sono figure geometriche, cioè estendono Shape)
            //allora posso aggiungerli alla lista
            shapes.Add(new Rectangle(2, 3.7));
            shapes.Add(new Circle(4.6));
            shapes.Add(new Square(1));

            //adesso sono interessato a leggere le informazioni delle figure geometriche
            //quindi ciclo su ogni elemento di shapes (la mia lista di figure geometriche)
            //la variabile shape nel ciclo foreach assumerà
            //  al primo giro il valore dell'oggetto Rectangle inserito nella lista
            //  al secondo giro il valore dell'oggetto Circle inserito nella lista
            //  al terzo giro il valore dell'oggetto Square inserito nella lista
            foreach (var shape in shapes)
            {
                System.Console.WriteLine($"{shape}");
                System.Console.WriteLine($"    perimeter is {shape.CalculatePerimeter()}");
                System.Console.WriteLine($"    surface is {shape.CalculateSurface()}");
                System.Console.WriteLine();
            }
        }
    }
}