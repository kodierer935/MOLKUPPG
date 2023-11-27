namespace D1.starts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = ""; 
            List<string> mylist = new List<string>();
            while (s != "sluta")
            {

                Console.Write("säg sluta så slutar ja: ");
                s = Console.ReadLine();
                if (s == "ny") 
                {
                    Console.Write("Mata in ny vara: ");
                    mylist.Add(Console.ReadLine());
                }
                else if (s == "ta bort") 
                {
                    Console.Write("ta bort vad?: ");
                    mylist.Remove(Console.ReadLine());
                
                }
                else if (s == "visa") 
                {
                    foreach (string item in mylist)
                    {
                        Console.Write(item);
                    }
                        
                }
            }
        }
    }
}