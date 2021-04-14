using InterviewTest;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            FizzBuzzService service = new FizzBuzzService();
            service.ToConsole();
        }
    }
}
