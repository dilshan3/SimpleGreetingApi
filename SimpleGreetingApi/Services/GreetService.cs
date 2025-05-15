namespace SimpleGreetApi.Services
{
    public class GreetService
    {
        public string Greet(string name)
        {
            return $"Hello, {name}! Welcome to CI/CD Demo.";
        }
    }
}
