namespace secondperyear
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double daysPerYear = 365.2422;
            double hoursPerDay = 24;
            double minutesPerHour = 60;
            double secondsPerMinute = 60;
            double secondsPerYear = daysPerYear * hoursPerDay * minutesPerHour * secondsPerMinute;
           Console.WriteLine("Total seconds per year: "+secondsPerYear+"");
        }
    }
}