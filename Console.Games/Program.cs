using Esercizi.Astrazioni.Interfaccia;
using Games.Model;

namespace Console.Games
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            System.Console.WriteLine("Hello, World!");

            var repository = new RoundRepository();
            var logger = new ConsoleLogger();

            var applicationService = new RoundFunctionalApplicationService(repository,
                                                                          repository,
                                                                          logger);

            var roundId = "1zxs31";
            applicationService.HandleCreate(new Commands.CreateNewRound(roundId));

            applicationService.HandleUpdate(new Commands.UpdateRoundNumber(roundId));
            applicationService.HandleUpdate(new Commands.UpdateRoundNumber(roundId));



            System.Console.ReadLine();
        }
    }
}