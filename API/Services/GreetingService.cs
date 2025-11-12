namespace API.Services
{
    public class GreetingService : IGreetingService
    {
        public string GetGreeting()
        {
            return "Hello World!";
        }
    }
}
