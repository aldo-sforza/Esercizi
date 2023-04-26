using Moq;
using Shapes.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.Tests.Mocks
{
    internal class MockIShapeRepository 
        : Mock<IShapesRepository>
    {

    }

    internal class MockIShapeQuery
        : Mock<IShapesQuery>
    {

    }
}
