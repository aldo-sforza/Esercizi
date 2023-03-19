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
            throw new NotImplementedException();
        }

        public void UpdateDuration(TimeSpan span)
        { throw new NotImplementedException(); }

        public void AssignOffender(Player offender)
        { throw new NotImplementedException(); }

        public void AssignDefender(Player offender)
        { throw new NotImplementedException(); }
    }
}