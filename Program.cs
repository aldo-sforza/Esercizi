using Esercizi.ApplicationServices;
using Esercizi.Astrazioni.Interfaccia;
using Esercizi.Caratteristiche_OOP.Ereditarietà.Shapes;
using Esercizi.Collections;
using Esercizi.Interfacce;
using Esercizi.Models;
using System;
using System.Collections.Generic;

internal class Program
{
    private static Dictionary<string, Action> _commands = new()
    {
        { "exit",()=>{ } },
        { "log",ExampleLogger },
        { "multilog",ExampleMultiLogger }
    };

    private static void Main(string[] args)
    {
        var roundRepository = new RoundRepository();
        var roundApplicationService = 
            new RoundApplicationService(roundRepository, roundRepository);
    }

    private static void Main2(string[] args)
    {
        string cmd = string.Empty;
        do
        {
            PrintCommands();
            cmd = Console.ReadLine();
            if (_commands.ContainsKey(cmd))
            {
                _commands[cmd]();
            }
            else
            {
                Console.WriteLine($"{cmd} è un comando sconosciuto");
            }
        }
        while (cmd != "exit");

        Console.WriteLine("ciao");

        //ExampleLogger();
        //OutputForShape();
        Console.ReadLine();
    }

    #region metodi

    private static void PrintCommands()
    {
        Console.WriteLine("scegli un comando");
        foreach (var cmd in _commands.Keys)
        {
            Console.WriteLine(cmd);
        }
        Console.WriteLine();
    }

    private static Dictionary<string, Func<ILogger>> _exampleCommands = new()
    {
        { "1",()=> new Esercizi.Astrazioni.Interfaccia.ConsoleLogger() },
        { "2",()=> new Esercizi.Astrazioni.Interfaccia.FileLogger() }
    };

    private static void ExampleLogger()
    {
        Console.WriteLine();
        Console.WriteLine("scegli il tipo");
        Console.WriteLine("1 - console logger da interfaccia");
        Console.WriteLine("2 - file logger da interfaccia");

        var cmd = Console.ReadLine();
        ExampleWithInterface example;
        if (_exampleCommands.ContainsKey(cmd))
        {
            example = new ExampleWithInterface(_exampleCommands[cmd]());
            example.DoSomethingGood();
            example.DoSomethingWarning();
            example.DoSomethingBad();
        }
        Console.WriteLine();
    }

    private static void ExampleMultiLogger()
    {
        List<ILogger> list = new List<ILogger>();
        list.Add(new Esercizi.Astrazioni.Interfaccia.ConsoleLogger());
        list.Add(new Esercizi.Astrazioni.Interfaccia.FileLogger());
        var example = new ExampleMultiLogger(list);

        example.DoSomethingGood();
        example.DoSomethingWarning();
        example.DoSomethingBad();
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
            Console.WriteLine($"{shape}");
            Console.WriteLine($"    perimeter is {shape.CalculatePerimeter()}");
            Console.WriteLine($"    surface is {shape.CalculateSurface()}");
            Console.WriteLine();
        }
    }

    private static void OutputForCollection()
    {
        var random = new Random();
        var numbers = new List<int>();

        for (int i = random.Next(5, 10); i > 0; i--)
        {
            numbers.Add(random.Next(100));
        }

        Console.WriteLine("Lista di numeri:");
        foreach (int i in numbers)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine("Numeri Pari:");
        foreach (int n in Collection.GetEvenNumbersLinq(numbers))
        {
            Console.WriteLine(n);
        }

        Console.WriteLine("Numero massimo:");
        Console.WriteLine(Collection.GetMax(numbers));

        Console.WriteLine("Numeri con indice dispari");
        foreach (int n in Collection.GetOddIndexNumbers(numbers))
        {
            Console.WriteLine(n);
        }

        Console.WriteLine("Lista di numeri invertita");
        foreach (int n in Collection.GetInvertedList(numbers))
        {
            Console.WriteLine(n);
        }
    }

    #endregion metodi
}