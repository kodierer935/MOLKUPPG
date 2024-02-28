using System;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp4
{

    class MainClass
    {
        class CelestialBody
        {
            protected string name;
            public CelestialBody(string name) { this.name = name; }
        }
        class Planet : CelestialBody
        {
            double a; // Semimajor axis
            public Planet(string name, double a) : base(name)
            {
                this.a = a;
            }
            // ... skriv funktion här ...
            public override string ToString()
            {
                return $"planet {name} (a = {a})";
            }
        }
        public static void Main(string[] args)
        {
            CelestialBody[] bodies = new CelestialBody[]
            {
                new Planet("Mercury", 0.4), new Planet("Venus", 0.7),
                new Planet("Earth", 1.0)
            };
            foreach (CelestialBody cel in bodies)
                Console.WriteLine(cel);
        }
    }
}
        

