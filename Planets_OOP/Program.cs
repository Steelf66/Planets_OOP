using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace Planets_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            //now im sad i didn't use the english names for the planets
            Planet Merkur = new Planet();

            Merkur.Name = "Merkur";
            Merkur.Mass = 0.330;
            Merkur.Diameter = 4879;
            Merkur.Density = 5427;
            Merkur.Gravity = 3.7;
            Merkur.Rotation = 1407.6;
            Merkur.LengthofDay = 4222.6;
            Merkur.DistancefromSun = 57.9;
            Merkur.OrbitalP = 88;
            Merkur.OrbitalV = 47.4;
            Merkur.MeanTemperature = 167;
            Merkur.NumberofMoons = 0;
            Merkur.RingSystem = "No";

            Planet Jorden = new Planet();

            Jorden.Name = "Jorden";
            Jorden.Mass = 5.97;
            Jorden.Diameter = 12756;
            Jorden.Density = 5514;
            Jorden.Gravity = 9.8;
            Jorden.Rotation = 23.9;
            Jorden.LengthofDay = 24;
            Jorden.DistancefromSun = 149.6;
            Jorden.OrbitalP = 365.2;
            Jorden.OrbitalV = 29.8;
            Jorden.MeanTemperature = 15;
            Jorden.NumberofMoons = 1;
            Jorden.RingSystem = "No";

            Planet Mars = new Planet();

            Mars.Name = "Mars";
            Mars.Mass = 0.642;
            Mars.Diameter = 6792;
            Mars.Density = 3933;
            Mars.Gravity = 3.7;
            Mars.Rotation = 24.6;
            Mars.LengthofDay = 24.7;
            Mars.DistancefromSun = 227.9;
            Mars.OrbitalP = 687;
            Mars.OrbitalV = 24.1;
            Mars.MeanTemperature = -65;
            Mars.NumberofMoons = 2;
            Mars.RingSystem = "No";

            Planet Jupiter = new Planet();

            Jupiter.Name = "Jupiter";
            Jupiter.Mass = 1898;
            Jupiter.Diameter = 142984;
            Jupiter.Density = 1326;
            Jupiter.Gravity = 23.1;
            Jupiter.Rotation = 9.9;
            Jupiter.LengthofDay = 9.9;
            Jupiter.DistancefromSun = 778.6;
            Jupiter.OrbitalP = 4331;
            Jupiter.OrbitalV = 13.1;
            Jupiter.MeanTemperature = -110;
            Jupiter.NumberofMoons = 67;
            Jupiter.RingSystem = "Yes";

            Planet Saturn = new Planet();

            Saturn.Name = "Saturn";
            Saturn.Mass = 568;
            Saturn.Diameter = 120536;
            Saturn.Density = 687;
            Saturn.Gravity = 9.0;
            Saturn.Rotation = 10.7;
            Saturn.LengthofDay = 10.7;
            Saturn.DistancefromSun = 1433.5;
            Saturn.OrbitalP = 10747;
            Saturn.OrbitalV = 9.7;
            Saturn.MeanTemperature = -140;
            Saturn.NumberofMoons = 62;
            Saturn.RingSystem = "Yes";

            Planet Uranus = new Planet();

            Uranus.Name = "Uranus";
            Uranus.Mass = 86.8;
            Uranus.Diameter = 51118;
            Uranus.Density = 1271;
            Uranus.Gravity = 8.7;
            Uranus.Rotation = -17.2;
            Uranus.LengthofDay = 17.2;
            Uranus.DistancefromSun = 2872.5;
            Uranus.OrbitalP = 30589;
            Uranus.OrbitalV = 6.8;
            Uranus.MeanTemperature = -195;
            Uranus.NumberofMoons = 27;
            Uranus.RingSystem = "Yes";

            Planet Neptun = new Planet();

            Neptun.Name = "Neptun";
            Neptun.Mass = 102;
            Neptun.Diameter = 49528;
            Neptun.Density = 1638;
            Neptun.Gravity = 11;
            Neptun.Rotation = 16.1;
            Neptun.LengthofDay = 16.1;
            Neptun.DistancefromSun = 4495.1;
            Neptun.OrbitalP = 59.8;
            Neptun.OrbitalV = 5.4;
            Neptun.MeanTemperature = -200;
            Neptun.NumberofMoons = 14;
            Neptun.RingSystem = "Yes";

            Planet Pluto = new Planet();

            Pluto.Name = "pluto";
            Pluto.Mass = 0.0146;
            Pluto.Diameter = 2370;
            Pluto.Density = 2095;
            Pluto.Gravity = 0.7;
            Pluto.Rotation = -153.3;
            Pluto.LengthofDay = 153.3;
            Pluto.DistancefromSun = 5906.4;
            Pluto.OrbitalP = 90.56;
            Pluto.OrbitalV = 4.7;
            Pluto.MeanTemperature = -225;
            Pluto.NumberofMoons = 5;
            Pluto.RingSystem = "No";


            List<Planet> Planets = new List<Planet>();
            //here i've added the planets Merkur, Jorden, Mars, Jupiter, Saturn, Uranus, Neptun, Pluto' in that order.
            Planets.Add(Merkur);
            Planets.Add(Jorden);
            Planets.Add(Mars);
            Planets.Add(Jupiter);
            Planets.Add(Saturn);
            Planets.Add(Uranus);
            Planets.Add(Neptun);
            Planets.Add(Pluto);
            Console.WriteLine();
            //here i made print out the list
            foreach (Planet Planet in Planets)
            {
                Console.WriteLine(Planet.Name);
            }
            Console.WriteLine("Press ENTER to add Venus");
            Console.ReadLine();
            Console.WriteLine();

            Planet Venus = new Planet();

            Venus.Name = "Venus";
            Venus.Mass = 4.87;
            Venus.Diameter = 12104;
            Venus.Density = 5243;
            Venus.Gravity = 8.9;
            Venus.Rotation = -5832.5;
            Venus.LengthofDay = 2802;
            Venus.DistancefromSun = 108.2;
            Venus.OrbitalP = 224.7;
            Venus.OrbitalV = 35;
            Venus.MeanTemperature = 464;
            Venus.NumberofMoons = 0;
            Venus.RingSystem = "No";
            // this should add Venus between Mercry and Earth, by using Planets.Insert(1, Venus) i insert Venus in the 2nd place, 
            // using 1 cus is goes 0,1,2,3,4. so that means 0 is Mercry and 1 was Earth. so i pushed the list by one to the right so Earth got 2 and Venus got 1.
            Planets.Insert(1, Venus);

            foreach (Planet Planet in Planets)
            {
                Console.WriteLine(Planet.Name);
            }
            Console.WriteLine("Press ENTER again to remove Pluto");
            Console.ReadLine();
            Console.WriteLine();

            Planets.Remove(Pluto);
            foreach (Planet Planet in Planets)
            {
                Console.WriteLine(Planet.Name);
            }
            Console.WriteLine("Press ENTER again to add back Pluto");
            Console.ReadLine();
            Console.WriteLine("You better say sorry for removing Pluto >:C");
            Console.WriteLine();

            Planets.Add(Pluto);
            foreach (Planet Planet in Planets)
            {
                Console.WriteLine(Planet.Name);
            }
            Console.WriteLine("Press ENTER again to see how many planets");
            Console.ReadLine();
            Console.WriteLine(Planets.Count);

            Console.WriteLine("Press ENTER again to see planets temps below zero ");
            Console.ReadLine();
            Console.WriteLine();

            List<Planet> Planetstemp = new List<Planet>();

            foreach (Planet Planet in Planets)
            {
                if (Planet.MeanTemperature < 0)
                {
                    Planetstemp.Add(Planet);
                }
            }
            foreach (Planet planet in Planetstemp)
            {
                Console.WriteLine(planet.Name);
            }
            Console.WriteLine("Press ENTER again to see planets with a diameter between 10000 km and 50000 km");
            Console.ReadLine();
            Console.WriteLine();

            List<Planet> planetsDia = new List<Planet>();

            foreach (Planet planet in Planets)
            {
                if (planet.Diameter >= 10000 && planet.Diameter < 50000)
                {
                    planetsDia.Add(planet);
                }
            }
            foreach (Planet Planet in planetsDia)
            {
                Console.WriteLine(Planet.Name);
            }
            Console.WriteLine("Press ENTER again to clear the planet list");
            Console.ReadLine();

            Planets.Clear();

            Console.WriteLine("There the list is gone");
            Console.ReadLine();
        }
    }
}
