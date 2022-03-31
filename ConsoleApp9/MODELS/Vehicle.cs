using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9.MODELS
{
    abstract class Vehicle
    {
        public double _drivetime;
        public double _distance;
        public double DriveTime { get; set; }
        public double Distance { get; set; }

        public Vehicle(double drivetime, double distance)
        {
            DriveTime = drivetime;
            Distance = distance;

        }
        public double AverageSpeed()
        {
            double result = Distance / DriveTime;
            return result;
        }
    }
}
