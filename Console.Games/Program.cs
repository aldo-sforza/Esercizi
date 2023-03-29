using Esercizi.Astrazioni.Interfaccia;
using Games.Model;
using System.ComponentModel.DataAnnotations;
using System.Drawing;

namespace Console.Game
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            System.Console.WriteLine("Hello, World!");

            var roundRepository = new RoundRepository();
            var playerRepository = new PlayerRepository();
            var logger = new ConsoleLogger();

            var roundApplicationService = new RoundFunctionalApplicationService(roundRepository,
                                                                          roundRepository,
                                                                          logger);
            var playerApplicationService = new PlayerFunctionalApplicationService(playerRepository,
                                                                                  playerRepository,
                                                                                  logger);

            var roundId = "1zxs31";
            var offenderId = "qwerty";
            var defenderId = "point";

            try
            {
                roundApplicationService.HandleCreate(new Games.Model.Commands.CreateNewRound(roundId));
            }
            catch (InvalidOperationException ex)
            {
                logger.WriteError(ex.Message);
            }

            roundApplicationService.HandleUpdate(new Games.Model.Commands.UpdateRoundNumber(roundId));
            roundApplicationService.HandleUpdate(new Games.Model.Commands.UpdateRoundNumber(roundId));

            try
            {
                playerApplicationService.HandleCreate(offenderId);
            }
            catch(InvalidOperationException ex)
            {
                logger.WriteError(ex.Message);
            }

            try
            {
                playerApplicationService.HandleCreate(defenderId);

            }
            catch (InvalidOperationException ex)
            {
                logger.WriteError(ex.Message);
            }            
            
            var offender = playerApplicationService.GetPlayer(offenderId);
            var defender = playerApplicationService.GetPlayer(defenderId);

            roundApplicationService.HandleUpdate(new Games.Model.Commands.AssignOffender(roundId, offender));
            roundApplicationService.HandleUpdate(new Games.Model.Commands.AssignDefender(roundId, defender));



            System.Console.ReadLine();
        }
    }
}