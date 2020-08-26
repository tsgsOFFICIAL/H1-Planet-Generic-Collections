using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace H1_Planet_Collections
    {
    class Planet
        {
        #region Fields
        private bool ringSystem;
        private byte numberOfMoons;
        private short density;
        private short meanTemperature;
        private string name;
        private double gravity;
        private double lengthOfDay;
        private double orbitalPeriod;
        private double rotationPeriod;
        private double orbitalVelocity;
        private double distanceFromSun;
        private double mass;
        private double diameter;
        #endregion

        #region Properties
        public enum Planets
            {
            Mercury,
            Venus,
            Earth,
            Mars,
            Jupiter,
            Saturn,
            Uranus,
            Neptune,
            Pluto
            }

        public string Name
            {
            get
                {
                return name;
                }
            }

        public short MeanTemperature
            {
            get
                {
                return meanTemperature;
                }
            }

        public double Diameter
            {
            get
                {
                return diameter;
                }
            }
        #endregion

        #region Constructors
        /// <summary>
        /// Constructor for Planet class, taking a string as a parameter
        /// </summary>
        /// <param name="planet">Specifies what planet to create</param>
        public Planet(Planets planet)
            {
            //Initialsie each planet with its correct properties
            switch (planet)
                {
                case Planets.Mercury:
                    InitialisePlanet(Planets.Mercury.ToString(), 0.330, 4879, 5427, 3.7, 1407.6, 4222.6, 57.9, 88.0, 47.4, 167, 0, false);
                    break;
                case Planets.Venus:
                    InitialisePlanet(Planets.Venus.ToString(), 4.87, 12104, 5243, 8.9, -5832.5, 2802.0, 108.2, 224.7, 35.0, 464, 0, false);
                    break;
                case Planets.Earth:
                    InitialisePlanet(Planets.Earth.ToString(), 5.97, 12756, 5514, 9.8, 23.9, 24.0, 149.6, 365.2, 29.8, 15, 1, false);
                    break;
                case Planets.Mars:
                    InitialisePlanet(Planets.Mars.ToString(), 0.642, 6792, 3933, 3.7, 24.6, 24.7, 227.9, 687.0, 24.1, -65, 2, false);
                    break;
                case Planets.Jupiter:
                    InitialisePlanet(Planets.Jupiter.ToString(), 1898, 142984, 1326, 23.1, 9.9, 9.9, 778.6, 4331, 13.1, -110, 67, true);
                    break;
                case Planets.Saturn:
                    InitialisePlanet(Planets.Saturn.ToString(), 568, 120536, 687, 9.0, 10.7, 10.7, 1433.5, 10747, 9.7, -140, 62, true);
                    break;
                case Planets.Uranus:
                    InitialisePlanet(Planets.Uranus.ToString(), 86.8, 51118, 1271, 8.7, -17.2, 17.2, 2872.5, 30589, 6.8, -195, 27, true);
                    break;
                case Planets.Neptune:
                    InitialisePlanet(Planets.Neptune.ToString(), 102, 49528, 1638, 11.0, 16.1, 16.1, 4495.1, 59.8, 5.4, -200, 14, true);
                    break;
                case Planets.Pluto:
                    InitialisePlanet(Planets.Pluto.ToString(), 0.0146, 2370, 2095, 0.7, -153.3, 153.3, 5906.4, 90.56, 4.7, -225, 5, false);
                    break;
                }
            }
        #endregion

        #region Methods
        /// <summary>
        /// Initialise a specific planet, with its given properties
        /// </summary>
        /// <param name="ringSystem">Does it have a ringsystem</param>
        /// <param name="gravity">Whats the gravitational force</param>
        /// <param name="numberOfMoons">How many moons does it have</param>
        /// <param name="density">How dense is it</param>
        /// <param name="meanTemperature">What is the mean temperature</param>
        /// <param name="lengthOfDay">How long is one day</param>
        /// <param name="orbitalPeriod">How long is its orbital period in days</param>
        /// <param name="rotationPeriod">How long is its rotation period in hours</param>
        /// <param name="orbitalVelocity">What is its orbital velocity in km/s</param>
        /// <param name="distanceFromSun">How far away from the sun is it (106km)</param>
        /// <param name="mass">What is its total mass (1024kg)</param>
        /// <param name="diameter">What is its diameter in km</param>
        private void InitialisePlanet(string name, double mass, double diameter, short density, double gravity, double rotationPeriod, double lengthOfDay, double distanceFromSun, double orbitalPeriod, double orbitalVelocity, short meanTemperature, byte numberOfMoons, bool ringSystem)
            {
            this.name = name;
            this.ringSystem = ringSystem;
            this.gravity = gravity;
            this.numberOfMoons = numberOfMoons;
            this.density = density;
            this.meanTemperature = meanTemperature;
            this.lengthOfDay = lengthOfDay;
            this.orbitalPeriod = orbitalPeriod;
            this.rotationPeriod = rotationPeriod;
            this.orbitalVelocity = orbitalVelocity;
            this.distanceFromSun = distanceFromSun;
            this.mass = mass;
            this.diameter = diameter;
            }
        #endregion
        }
    }
