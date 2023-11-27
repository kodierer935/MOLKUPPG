namespace Whiletabell
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int h = 1;
            int v = 1;
            int count = 1;
            string line = " ";
            int gng = 1;
            Console.WriteLine("test");
            int counted = 1;

            while (h <= 10)
            {
                
                while (v <= 10)
                {
                    
                    counted = count / v;
                    line = line + " " + counted;
                    v++;
                }
                Console.WriteLine(line);
                h++;
                line = " ";
                v = 1;
                count = h;
                counted = 1;
            }
        }
    }
}