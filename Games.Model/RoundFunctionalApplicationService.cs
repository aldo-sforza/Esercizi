using Esercizi.Astrazioni.Interfaccia;
using Patterns.Repository;

namespace Games.Model
{
    public static class Commands
    {
        public record CreateNewRound(string RoundId);
        public record UpdateRoundNumber(string RoundId);
        public record UpdateRoudDuration(string RoundId, TimeSpan Duration);

        public record AssignOffender(string RoundId, Player Offender);
        public record AssignDefendeer(string RoundId, Player Defender);
        public record UpdateDenderHealth(string RoundId, int Damage);
    }


    public class RoundFunctionalApplicationService
    {
        private readonly IRepository<Round> _roundRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger _logger;

        public RoundFunctionalApplicationService(IRepository<Round> repository,
                                       IUnitOfWork unitOfWork,
                                       ILogger logger)
        {
            _roundRepository = repository;
            _unitOfWork = unitOfWork;
            _logger = logger;
        }

        public void HandleCreate(Commands.CreateNewRound command)
        {
            _roundRepository.Create(command.RoundId);
            _unitOfWork.SaveChanges();
        }

        public void HandleUpdate(object command)
        {
            Round round = new Round("");
            switch (command)
            {
                case Commands.UpdateRoundNumber e:
                    if (TryGet(e.RoundId, out round))
                    {
                        round.Number++;
                        _unitOfWork.SaveChanges();
                        _logger.WriteInformation($"round with id {e.RoundId} number: {round.Number}");
                    }
                    break;

                case Commands.UpdateRoudDuration e:
                    if (TryGet(e.RoundId, out round))
                    {
                        round.Duration = e.Duration;
                        _unitOfWork.SaveChanges();
                    }
                    break;

                case Commands.AssignOffender e:
                    if (TryGet(e.RoundId, out round))
                    {
                        round.Offender = e.Offender;
                        _unitOfWork.SaveChanges();
                    }
                    break;

                case Commands.AssignDefendeer e:
                    if (TryGet(e.RoundId, out round))
                    {
                        round.Defender = e.Defender;
                        _unitOfWork.SaveChanges();
                    }
                    break;
                case Commands.UpdateDenderHealth e:
                    if (TryGet(e.RoundId, out round))
                    {
                        round.Defender.Health-= e.Damage;
                        _unitOfWork.SaveChanges();
                    }
                    break;
                default:
                    break;
            }
        }

        private bool TryGet(string roundId, out Round round)
        {
            round = null;
            if (_roundRepository.Exists(roundId))
            {
                round = _roundRepository.Load(roundId);
                return true;
            }
            return false;
        }
    }
}