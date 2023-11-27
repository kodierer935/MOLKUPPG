namespace Loop1to10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            while(i <= 10)
            {
                Console.WriteLine("i = " + i);
                
                if (i % 2 == 0)
                {
                    Console.WriteLine(" Är JÄMN");
                }
                else
                {
                    Console.WriteLine(" Är UDDA");

                }
                i++;
                Console.WriteLine("kvadraten: " + Math.Pow(i, 2));
                Console.WriteLine("Kvadratroten: " + Math.Pow(i, 1 / 2));

            }
        }
    }
}