using Esercizi.Astrazioni.Interfaccia;
using Games.Model;
using Moq;
using Patterns.Repository;

namespace Games.Tests.Mocks
{
    internal class MockPlayerRepository
        : Mock<IRepository<Player>>
    {
        public void GivenPlayerDoesNotExist(string id)
        {
            Setup(repository => repository.Exists(id))
                .Returns(false);
        }
        public void GivenPlayerDoesExist()
        {
            Setup(repository => repository.Exists(It.IsAny<string>()))
                .Returns(true);
        }

        public void GivenCreateIsCalled(Times times)
        {
            Verify(repository => repository.Create(It.IsAny<string>()), times);
        }

        public void GivenExistIsCalledOnce()
        {
            Verify(repository=> repository.Exists(It.IsAny<string>()),Times.Once());
        }
    }

    internal class MockPlayerUnitOfWork
        : Mock<IUnitOfWork>
    {
        public void GivenSaveChangesIsCalled(Times times)
        {
            Verify(unitOfWork => unitOfWork.SaveChanges(), times);
        }
    }

    internal class MockLogger
        : Mock<ILogger>
    {
        public void GivenWriteInformationIsCalled(Times times)
        {
            Verify(logger => logger.WriteInformation(It.IsAny<string>()), times);
        }
    }
}