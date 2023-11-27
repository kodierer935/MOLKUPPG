using System.Diagnostics.Tracing;
using System.Reflection.Metadata;

namespace latinordlista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            Console.Write("säg sluta eller hjälp:");
            string s = Console.ReadLine();
            while (s != "sluta") 
            {
                Console.Write("säg sluta eller hjälp:");
                s = Console.ReadLine();
                if (s == "hjälp")
                {
                    Console.WriteLine("Ny skapar ny latinsk ord med svensk betydelse\n" +
                        "sluta avslutar programmet\n" +
                        "ta bort tar bort ett ord med översättningen" +
                        "svenska visar översättningen av ett latisnk ord" +
                        "visa visar ordlistan");

                }
                else if (s == "Ny")
                {
                    Console.Write("Mata in ny ord i latin:");
                    string a = Console.ReadLine();
                    Console.Write("Mata in översättning: ");
                    dic.Add(a, Console.ReadLine());
                }
                else if (s.Contains("latin")){
                    Console.Write("svenska till latin?");
                    string d = dic[Console.ReadLine()];
                    Console.WriteLine(d);
                }
                else if (s == "latin till svenska?") {
                    string n = dic[Console.ReadLine()];
                    Console.WriteLine(n);
                }
                else if (s =="visa") {
                    foreach (var word in dic) 
                    {  Console.Write(word); }
                }
            }
        }
    }
}