using Esercizi.Astrazioni.Interfaccia;
using Games.Model;
using Patterns.Repository;

namespace Esercizi.ApplicationServices
{
    public class RoundApplicationService
    {
        private readonly IRepository<Round> _repository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger _logger;

        public RoundApplicationService(IRepository<Round> repository,
                                       IUnitOfWork unitOfWork,
                                       ILogger logger)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
            _logger = logger;
        }

        public void NewRound(string id)
        {
            _repository.Create(id);
            _unitOfWork.SaveChanges();
        }

        public void UpdateRoundNumber(string roundId)
        {
            if (TryGet(roundId, out Round round))
            {
                round.Number++;
                _unitOfWork.SaveChanges();
            };
        }

        public void UpdateDuration(string roundId, TimeSpan span)
        {
            if (TryGet(roundId, out Round round))
            {
                round.Duration = span;
                _unitOfWork.SaveChanges();
            };
        }

        public void AssignOffender(string roundId, Player offender)
        {
            if (TryGet(roundId, out Round round))
            {
                round.Offender = offender;
                _unitOfWork.SaveChanges();
            };
        }

        public void UpdateDefenderHealth(string roundId, int damage)
        {
            if (TryGet(roundId, out Round round))
            {
                round.Defender.Health -= damage;
                _unitOfWork.SaveChanges();
            }
        }

        public void AssignDefender(string roundId, Player defender)
        {
            if (TryGet(roundId, out Round round))
            {
                round.Defender = defender;
                _unitOfWork.SaveChanges();
            };
        }

        private bool TryGet(string roundId, out Round round)
        {
            round = null;
            if (_repository.Exists(roundId))
            {
                round = _repository.Load(roundId);
                return true;
            }
            return false;
        }
    }
}