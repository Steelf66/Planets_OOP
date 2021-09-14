using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planets_OOP
{
  public class Planet
    {
        // Mass (1024kg)
        // Diameter (km)
        // Density (kg/m3)
        // Gravity (m/s2)
        // Rotation Period (hours)
        // Length of Day (hours)
        // Distance from Sun (106 km)
        // Orbital Period (days)
        // Orbital Velocity (km/s)
        // Mean Temperature (C)
        // Number of Moons
        // Ring System?
        // here is the properties for the planets
        private string name1;
        private double mass1;
        private double diameter1;
        private double density1;
        private double gravity1;
        private double rotation1;
        private double lengthofday1;
        private double distancefromsun1;
        private double orbitalP1;
        private double orbitalV1;
        private double meantemperature1;
        private double numberofmoons1;
        private string ringsystem1;

        //this is so the main class can pull the values
        public string Name
        { get { return this.name1; } set { name1 = value; } }

        public double Mass
        { get { return this.mass1; } set { mass1 = value; } }

        public double Diameter
        { get { return this.diameter1; } set { diameter1 = value; } }

        public double Density
        { get { return this.density1; } set { density1 = value; } }

        public double Gravity
        { get { return this.gravity1; } set { gravity1 = value; } }

        public double Rotation
        { get { return this.rotation1; } set { rotation1 = value; } }

        public double LengthofDay
        { get { return this.lengthofday1; } set { lengthofday1 = value; } }

        public double DistancefromSun
        { get { return this.distancefromsun1; } set { distancefromsun1 = value; } }

        public double OrbitalP
        { get { return this.orbitalP1; } set { orbitalP1 = value; } }

        public double OrbitalV
        { get { return this.orbitalV1; } set { orbitalV1 = value; } }

        public double MeanTemperature
        { get { return this.meantemperature1; } set { meantemperature1 = value; } }

        public double NumberofMoons
        { get { return this.numberofmoons1; } set { numberofmoons1 = value; } }

        public string RingSystem
        { get { return this.ringsystem1; } set { ringsystem1 = value; } }
    }
}
