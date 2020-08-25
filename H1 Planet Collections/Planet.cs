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
        private byte gravity;
        private byte numberOfMoons;
        private short density;
        private short meanTemperature;
        private float lengthOfDay;
        private float orbitalPeriod;
        private float rotationPeriod;
        private float orbitalVelocity;
        private float distanceFromSun;
        private decimal mass;
        private decimal diameter;
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
        #endregion

        #region Constructors
        /// <summary>
        /// Constructor for Planet class, taking a string as a parameter
        /// </summary>
        /// <param name="planet">Specifies what planet to create</param>
        public Planet(Planets planet)
            {
            switch (planet)
                {
                case Planets.Mercury:
                    break;
                case Planets.Venus:
                    break;
                case Planets.Earth:
                    break;
                case Planets.Mars:
                    break;
                case Planets.Jupiter:
                    break;
                case Planets.Saturn:
                    break;
                case Planets.Uranus:
                    break;
                case Planets.Neptune:
                    break;
                case Planets.Pluto:
                    break;
                }
            }
        #endregion
        }
    }
