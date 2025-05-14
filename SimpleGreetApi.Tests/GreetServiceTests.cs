using SimpleGreetApi.Services;

namespace SimpleGreetApi.Tests
{
    public class GreetServiceTests
    {
        [Fact]
        public void Greet_ReturnsCorrectMessage()
        {
            var service = new GreetService();
            var result = service.Greet("Dilshan");
            Assert.Equal("Hello, Dilshan! Welcome to CI/CD Demo", result);
        }
    }
}
