using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9.MODELS
{
    class Car : Vehicle,IEngine,ITransmission
    {
        private int _doorcount;
        private string _wincode;
        public double _drivetime;
        public double _distance;
        public int DoorCount { get; set; }
        public int WinCode { get; set; }
    }
}
