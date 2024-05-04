using Moq;

namespace DemoServices.Test
{
    [TestFixture]
    public class SimpleInterestCalculationServiceTests
    {
        private Mock<INumberService> _mockedNumberService;

        private SimpleInterestCalculationService _service;

        [SetUp]
        public void Setup()
        {
            _mockedNumberService = new Mock<INumberService>();

            _service = new SimpleInterestCalculationService(_mockedNumberService.Object);
        }

        [TestCase(100, 10, 3)]
        public void GivenCorrectValues_WhenCalculate_ThenSimpleInterestCalculated(int principle, int rate, int years)
        {
            // Arrange
            _mockedNumberService.Setup(x => x.Multiply(It.IsAny<int>(), It.IsAny<int>(), It.IsAny<int>()))
                .Returns(principle * rate * years);

            _mockedNumberService.Setup(x => x.Divide(It.IsAny<int>(), It.IsAny<int>()))
                .Returns((principle * rate * years) / 100);

            // Act
            var result = _service.Calculate(100, 10, 3);

            // Assert
            _mockedNumberService.Verify(x => x.Multiply(principle, rate, years), Times.Once);

            _mockedNumberService.Verify(x => x.Divide(It.IsAny<int>(), It.IsAny<int>()), Times.Once);

            Assert.That(result, Is.EqualTo(30));
        }
    }
}
