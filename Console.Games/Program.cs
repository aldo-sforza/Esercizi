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

            var round = applicationService.HandleCreate(new Commands.CreateNewRound(""));
            applicationService.HandleUpdate(new Commands.UpdateRoundNumber(round.Id));
            applicationService.HandleUpdate(new Commands.UpdateRoundNumber(round.Id));



            System.Console.ReadLine();
        }
    }
}