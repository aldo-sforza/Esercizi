using FluentAssertions;
using Games.Model;
using Xunit;
using Moq;

namespace Games.Tests
{
    public class GamesTest
    {
        private Mocks.MockPlayerRepository _repository = new Mocks.MockPlayerRepository();
        private Mocks.MockPlayerUnitOfWork _playerUnitOfWork = new Mocks.MockPlayerUnitOfWork();
        private Mocks.MockLogger _logger = new Mocks.MockLogger();

        [Fact]
        public void HandleCreateSuccess()
        {
            //arrange
            var id = "123";
            _repository.GivenPlayerDoesNotExist(id);

            var playerApplicationService =
                new PlayerFunctionalApplicationService(_repository.Object,
                                                       _playerUnitOfWork.Object,
                                                       _logger.Object);

            //act
            playerApplicationService.HandleCreate(id);

            //assert
            _repository.GivenExistIsCalledOnce();
            _repository.GivenCreateIsCalled(Times.Once());
            _playerUnitOfWork.GivenSaveChangesIsCalled(Times.Once());
            _logger.GivenWriteInformationIsCalled(Times.Once());
        }

        [Fact]
        public void HnadleCreateFailsBecauseIdAlreadyExists()
        {
            _repository.GivenPlayerDoesExist();
            var playerApplicationService =
                new PlayerFunctionalApplicationService(_repository.Object,
                                                       _playerUnitOfWork.Object,
                                                       _logger.Object);

            try
            {
                playerApplicationService.HandleCreate("123");
            }
            catch (Exception ex)
            {

                ex.Should().BeOfType<InvalidOperationException>();
            }
            _repository.GivenExistIsCalledOnce();
            _repository.GivenCreateIsCalled(Times.Never());
            _playerUnitOfWork.GivenSaveChangesIsCalled(Times.Never());
            _logger.GivenWriteInformationIsCalled(Times.Never());


        }
    }
}