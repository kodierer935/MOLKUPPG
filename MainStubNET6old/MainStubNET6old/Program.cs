namespace MainStubNET6old
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.Write("enter a number: ");
            string val = Console.ReadLine();
            int ival = Int32.Parse(val);
            Console.WriteLine("value="+ival);
        }
    }
}