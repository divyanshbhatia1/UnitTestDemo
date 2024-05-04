using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoServices.Test
{
    [TestFixture]
    public class NumberServiceTests
    {
        private NumberService _numberService;

        [SetUp]
        public void Setup()
        {
            _numberService = new NumberService();
        }

        // Given... When... Then...
        [Test]
        public void GivenTwoPositiveNumbers_WhenCallAddMethod_ThenCorrectSum()
        {
            // Arrange

            // Act
            var result = _numberService.AddTwoNumbers(1, 1);

            // Assert
            Assert.That(result, Is.EqualTo(2));
        }

        // Given... When... Then...
        [Test]
        public void GivenTwoPositiveNumbers_WhenCallDivideMethod_ThenCorrectValueReturned()
        {
            // Arrange

            // Act
            var result = _numberService.Divide(1, 1);

            // Assert
            Assert.That(result, Is.EqualTo(1));
        }

        // Given... When... Then...
        [Test]
        public void GivenTwoPositiveNumbers_WhenCallDivideMethodWith0_ThenCorrectValueReturned()
        {
            // Arrange

            // Act / Assert
            Assert.Throws<DivideByZeroException>(() => _numberService.Divide(1, 0));
        }
    }
}
