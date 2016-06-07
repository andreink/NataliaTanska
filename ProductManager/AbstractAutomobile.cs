using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManager
{
    class AbstractAutomobile : AbstractVehicle
    {
        public Engine engine { get; set; }              // silnik
        public AbstractAutomobile(string pName, ushort pNo_wheels, bool pWheel_right, uint pPrice, Engine pEngine) :
            base(pName, pNo_wheels, pWheel_right, true, pPrice) //dziedziczenie
        {
            engine = pEngine;
        }

        public AbstractAutomobile() : base()
        {

        }

    }
}
