namespace mataintal
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("mata in startvärde: ");            
            int b;
            b = int.Parse(Console.ReadLine());
           
            Console.Write("slutVärde: ");
            int c;
            c = int.Parse(Console.ReadLine());

            int count = b;
            while (count <= c)
            {

                Console.WriteLine("i = " + b + ", i*i = " + Math.Pow(b, 2));
                b++;
                count++;
            }
        }
    }
}