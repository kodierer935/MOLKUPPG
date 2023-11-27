using System;
using System.IO;

namespace D1._1._1ordraknare
{
    class Program
    {
        static readonly string RootFolder = @"C:\Users\Erik\Desktop";
        static readonly string TextFile = @"C:\Users\Erik\Desktop\tester.txt";
        static void Main(string[] args)
        {
            Console.Write("What name?: ");
            string ai = RootFolder + "\\" + Console.ReadLine();
            string text = File.ReadAllText(ai);
            string[] lines = File.ReadAllLines(ai);
            
            int i = 0;
            foreach (string line in lines )
            {
                Console.WriteLine(line);
                i++;
            }
            
            int charcount = text.Length;

            string[] words = text.Split(' ');

            int c = words.Length + 1;

            Console.WriteLine("lines " + i);
            Console.WriteLine("characters " + charcount);
            Console.WriteLine("words " + c);

        }
    }
}