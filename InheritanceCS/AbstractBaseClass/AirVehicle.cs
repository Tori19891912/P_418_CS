using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractBaseClass
{
   abstract class AirVehicle:Vehicle
    {
        public int Altitude { get; set; }
        public abstract void TopUp();
        public abstract void Land();
    }
}
