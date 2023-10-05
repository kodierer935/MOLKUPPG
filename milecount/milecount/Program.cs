namespace milecount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("timmar:");
            string tim = Console.ReadLine();
            Console.Write("minuter:");
            string min = Console.ReadLine();
            Console.Write("mil:");
            string mil = Console.ReadLine();
            Console.Write("L per mil:");
            string bensin = Console.ReadLine();

            double bensind = double.Parse(bensin);
            double timd = double.Parse(tim);
            double mind = double.Parse(min);
            double mild = double.Parse(mil);
            

            double miles = mild * 10;
            double time = mind / 60 + timd;
            double div = miles / time;
            double benmil = mild * bensind;

            Console.WriteLine("Running "+div+"km/h");
            Console.WriteLine("Running " + benmiltest + " L i sträckan");
        }
    }
}