using Esercizi.Astrazioni.Interfaccia;
using Patterns.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Games.Model
{
    public class PlayerFunctionalApplicationService
    {
        private readonly IRepository<Player> _playerRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger _logger;

        public PlayerFunctionalApplicationService(IRepository<Player> playerRepository, 
                                        IUnitOfWork unitOfWork,
                                        ILogger logger) 
        {
            _playerRepository = playerRepository;
            _unitOfWork = unitOfWork;
            _logger = logger;
        }

        public void HandleCreate(string id)
        {
            if (_playerRepository.Exists(id))
                throw new InvalidOperationException($"ID: {id} already exists for the players");

            _playerRepository.Create(id);
            _unitOfWork.SaveChanges();
            _logger.WriteInformation($"Player with ID: {id} created");
        }

        public Player GetPlayer(string id)
        {
            return _playerRepository.Load(id);
        }
    }
}
