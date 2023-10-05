namespace ArgEnv
{

    internal class Program
    {
        static void Main(string[] args)
        {
            int X = -999;
            if (args[0] == "noll") X = 0;
            else if (args[0] == "ett") X = 1;
            else if (args[0] == "två") X = 2;
            else if (args[0] == "tre") X = 3;
            else if (args[0] == "fyra") X = 4;
            else if (args[0] == "fem") X = 5;
            else if (args[0] == "sex") X = 6;
            else if (args[0] == "sju") X = 7;
            else if (args[0] == "åtta") X = 8;
            else if (args[0] == "nio") X = 9;

            int Y = -999;
            if (args[2] == "noll") Y = 0;
            else if (args[2] == "ett") Y = 1;
            else if (args[2] == "två") Y = 2;
            else if (args[2] == "tre") Y = 3;
            else if (args[2] == "fyra") Y = 4;
            else if (args[2] == "fem") Y = 5;
            else if (args[2] == "sex") Y = 6;
            else if (args[2] == "sju") Y = 7;
            else if (args[2] == "åtta") Y = 8;
            else if (args[2] == "nio") Y = 9;

            int Z = -999;
            if (args[1] == "plus") Z = X + Y;
            else if (args[1] == "minus") Z = X - Y;
            else if (args[1] == "gånger") Z = X * Y;
            else if (args[1] == "delat med") Z = X / Y;

            if (Z == 0) Console.WriteLine("noll");
            else if (Z == 10) Console.WriteLine("tio");
            else if (Z == 11) Console.WriteLine("elva");
            else if (Z == 12) Console.WriteLine("tolv");
            else if (Z == 13) Console.WriteLine("tretton");
            else if (Z == 14) Console.WriteLine("fjorton");
            else if (Z == 15) Console.WriteLine("femton");
            else if (Z == 16) Console.WriteLine("sexton");
            else if (Z == 17) Console.WriteLine("sjutton");
            else if (Z == 18) Console.WriteLine("arton");
            else if (Z == 19) Console.WriteLine("nitton");
            else
            {
                int tiotal = Z / 10;
                int ental = Z % 10;
                if (tiotal == 2) Console.Write("tjugu");
                else if (tiotal == 3) Console.Write("trettio");
                else if (tiotal == 4) Console.Write("fyrtio");
                else if (tiotal == 5) Console.Write("femtio");
                else if (tiotal == 6) Console.Write("sextio");
                else if (tiotal == 7) Console.Write("sjuttio");
                else if (tiotal == 8) Console.Write("åttio");
                else if (tiotal == 9) Console.Write("nittio");
                if (ental == 1) Console.WriteLine("ett");
                else if (ental == 2) Console.WriteLine("två");
                else if (ental == 3) Console.WriteLine("tre");
                else if (ental == 4) Console.WriteLine("fyra");
                else if (ental == 5) Console.WriteLine("fem");
                else if (ental == 6) Console.WriteLine("sex");
                else if (ental == 7) Console.WriteLine("sju");
                else if (ental == 8) Console.WriteLine("åtta");
                else if (ental == 9) Console.WriteLine("nio");
            }
        }
    }
}