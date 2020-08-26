using System;
using System.Linq;

namespace H1_Planet_Collections
    {
    class Program
        {
        static void Main(string[] args)
            {
            System.Collections.Generic.List<Planet> planets = new System.Collections.Generic.List<Planet>(); //Generate & Initialise a new List<Planet>

            Console.ForegroundColor = ConsoleColor.White;

            //Initialise the planets
            Planet mercury = new Planet(Planet.Planets.Mercury);
            Planet venus = new Planet(Planet.Planets.Venus);
            Planet earth = new Planet(Planet.Planets.Earth);
            Planet mars = new Planet(Planet.Planets.Mars);
            Planet jupiter = new Planet(Planet.Planets.Jupiter);
            Planet saturn = new Planet(Planet.Planets.Saturn);
            Planet uranus = new Planet(Planet.Planets.Uranus);
            Planet neptune = new Planet(Planet.Planets.Neptune);
            Planet pluto = new Planet(Planet.Planets.Pluto);

            //Add the planets, except for poor venus
            planets.Add(mercury);
            planets.Add(earth);
            planets.Add(mars);
            planets.Add(jupiter);
            planets.Add(saturn);
            planets.Add(uranus);
            planets.Add(neptune);
            planets.Add(pluto);

            //Output all planets in planets
            Console.WriteLine("Iteration 1\n");

            foreach (Planet planet in planets)
                {
                Console.WriteLine(planet.Name);
                }

            //Output all planets in planets again
            Console.WriteLine("\nIteration 2\n");

            planets.Insert(1, venus);

            foreach (Planet planet in planets)
                {
                Console.WriteLine(planet.Name);
                }

            //Remove pluto

            foreach (Planet planet in planets)
                {
                if (planet.Name.Equals(pluto.Name))
                    {
                    planets.Remove(planet);
                    break;
                    }
                }

            //Output all planets in planets for a third time
            Console.WriteLine("\nIteration 3\n");

            foreach (Planet planet in planets)
                {
                Console.WriteLine(planet.Name);
                }

            //Add pluto again

            planets.Add(pluto);

            //Output the number of planets to the console

            Console.WriteLine("\nThere is {0} planets in your list!", planets.Count); //First way of doing it
            //Console.WriteLine($"There is {planets.Count} planets in your list!"); //Doing it with interpolation
            //Console.WriteLine("There is " + planets.Count + " planets in your list!"); //Doing it Java style, aka, concatenation

            //All three ways are valid, the 2 first are the most used in C#

            //Make a new List<Planet>

            System.Collections.Generic.List<Planet> newPlanets = new System.Collections.Generic.List<Planet>();

            foreach (Planet planet in planets)
                {
                if (planet.MeanTemperature < 0)
                    {
                    newPlanets.Add(planet);
                    }
                }

            //New list again

            System.Collections.Generic.List<Planet> newPlanetsv2 = new System.Collections.Generic.List<Planet>();

            foreach (Planet planet in planets)
                {
                if (planet.Diameter > 10000 && planet.Diameter < 50000)
                    {
                    newPlanetsv2.Add(planet);
                    }
                }

            newPlanetsv2.Clear(); //Remove everything from the list, aka. Clear the list
            Console.ReadKey(true); //Wait for a keypress before closing the console
            }
        }
    }
