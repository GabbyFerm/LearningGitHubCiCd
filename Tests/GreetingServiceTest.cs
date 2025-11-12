using API.Services;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GetGreeting_Returns_HelloWorld()
        {
            // Arrange
            IGreetingService service = new GreetingService();

            // Act
            var result = service.GetGreeting();

            // Assert
            Assert.That(result, Is.EqualTo("Hello World!"));
        }
    }
}