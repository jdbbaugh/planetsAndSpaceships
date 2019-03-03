using System;
using System.Collections.Generic;

namespace planetsAndSpaceships
{
    public class Program
    {
        public static void Main()
        {
            List<string> planetList = new List<string>() {"Mercury", "Mars"};

            planetList.Add("Jupiter");
            planetList.Add("Saturn");

            List<string> morePlanets = new List<string>() {"Uranus","Neptune"};
            planetList.AddRange(morePlanets);


            planetList.Insert(1, "Venus");
            planetList.Insert(2, "Earth");
            planetList.Add("Pluto");
            List<string> rockyPlanets = new List<string>(planetList.GetRange(0, 4));
            planetList.Remove("Pluto");

            foreach(string planet in planetList)
            {
                Console.WriteLine(planet);
            }

            Console.WriteLine();
            Console.WriteLine("rocky planets");
            foreach(string planet in rockyPlanets)
            {
                Console.WriteLine(planet);
            }
        }
    }
}