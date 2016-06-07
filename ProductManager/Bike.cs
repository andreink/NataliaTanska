using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManager
{
    class Bike : AbstractVehicle
    {
        public ushort gears { get; set; } // ilość biegów
        public Bike(string pName, ushort pNo_wheels, bool pWheel_right, bool pHas_engine, uint pPrice, ushort pGears) :
            base(pName, pNo_wheels, pWheel_right, false, pPrice)
        {
            gears = pGears;
        }
        public Bike():base()
        {

        }
    }
}
