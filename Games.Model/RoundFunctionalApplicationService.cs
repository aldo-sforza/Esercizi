using Patterns.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Games.Model
{
    public static class Commands
    {
        public record CreateNewRound();
    }

    public class RoundFunctionalApplicationService
    {
        private readonly IRepository<Round> _repository;
        private readonly IUnitOfWork _unitOfWork;
        public RoundFunctionalApplicationService(IRepository<Round> repository,
                                       IUnitOfWork unitOfWork)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
        }

        public Round HandleCreate(Commands.CreateNewRound command)
        {
            var round =_repository.Create();
            _unitOfWork.SaveChanges();
            return round;
        }
        public void HandleUpdate(object command)
        {
            switch (command)
            {
                case Commands.CreateNewRound e:
                    _repository.Create();
                    _unitOfWork.SaveChanges();
                    break;
                default:
                    break;
            }

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
