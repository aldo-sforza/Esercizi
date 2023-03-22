using Games.Model;
using Patterns.Repository;

namespace Esercizi.ApplicationServices
{
    public class RoundApplicationService
    {
        private readonly IRepository<Round> _repository;
        private readonly IUnitOfWork _unitOfWork;

        public RoundApplicationService(IRepository<Round> repository,
                                       IUnitOfWork unitOfWork)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
        }

        public Round NewRound()
        {
            var round = _repository.Create();
            _unitOfWork.SaveChanges();
            return round;
        }

        public void UpdateRoundNumber(string roundId)
        {
            if (_repository.Exists(roundId))
            {
                var round = _repository.Load(roundId);
                round.Number++;
                _unitOfWork.SaveChanges();
            }
        }

        public void UpdateDuration(string roundId, TimeSpan span)
        {
            if (_repository.Exists(roundId))
            {
                var round = _repository.Load(roundId);
                round.Duration = span;
                _unitOfWork.SaveChanges();
            }
        }

        public void AssignOffender(string roundId, Player offender)
        {
            if (_repository.Exists(roundId))
            {
                var round = _repository.Load(roundId);
                round.Offender = offender;
                _unitOfWork.SaveChanges();
            }
        }

        public void AssignDefender(string roundId, Player defnder)
        {
            if (_repository.Exists(roundId))
            {
                var round = _repository.Load(roundId);
                round.Defender = defnder;
                _unitOfWork.SaveChanges();
            }
        }
    }
}