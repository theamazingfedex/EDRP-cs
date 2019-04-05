using System;
using System.Collections.Generic;

namespace EDRP.Journal.Models
{
    public class JournalMessage
    {
        public double AbsoluteMagnitude { get; set; }
        public int Age_MY { get; set; }
        public double AxialTilt { get; set; }
        public int BodyID { get; set; }
        public string BodyName { get; set; }
        public double DistanceFromArrivalLS { get; set; }
        public double Eccentricity { get; set; }
        public string Luminosity { get; set; }
        public double OrbitalInclination { get; set; }
        public double OrbitalPeriod { get; set; }
        // public List<Parent> Parents { get; set; }
        public double Periapsis { get; set; }
        public double Radius { get; set; }
        public double RotationPeriod { get; set; }
        public string ScanType { get; set; }
        public double SemiMajorAxis { get; set; }
        public List<double> StarPos { get; set; }
        public string StarSystem { get; set; }
        public string StarType { get; set; }
        public double StellarMass { get; set; }
        public double SurfaceTemperature { get; set; }
        public long SystemAddress { get; set; }
        public string @event { get; set; }
        public DateTime timestamp { get; set; }
    }

    // public class Parent
    // {
    //     public int Null { get; set; }
    // }
}