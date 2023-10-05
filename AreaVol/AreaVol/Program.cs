namespace AreaVol
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter side meters: ");

            string sidestr = Console.ReadLine();
            double side = double.Parse(sidestr);

            Console.WriteLine("The side of the cube is "+side+" meters");
            double area = side * side * 6;
            Console.WriteLine("the surface area of the cube is " + area + " meters");
            double volume = Math.Pow(side, 3);
            Console.WriteLine("the volume of the cube is "+volume+" Cubic meters");
            double volsphere = 4/3 * Math.PI * volume;
            Console.WriteLine("The volume of the sphere is " + volsphere + " cubic meters");
            double radius = Math.Pow(volume, 1/3);
            Console.WriteLine("the radius is " + radius + "meters");

        }
    }
}