namespace Env
{

    internal class Program
    {
        static void Main(string[] args)
        {
            string lang = Environment.GetEnvironmentVariable("language");
            Console.WriteLine($"{lang}");
            if (lang == "sv")
            {
                Console.WriteLine("Hej världen!");
            }
            else if (lang == "en")
            {
                Console.WriteLine("Hello, World!");
            }
            else
            {
                Console.WriteLine("Kakk, Aaaak!");
            }
        }
    }
}