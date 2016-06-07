using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManager
{
    class Motorcycle : AbstractAutomobile
    {
        public string type { get; set; }
        public Motorcycle(string pName, ushort pNo_wheels, bool pWheel_right, uint pPrice, string pType, string engine_type, double engine_capacity, uint engine_horsepower, uint engine_milage) :
            base(pName, pNo_wheels, pWheel_right, pPrice, new Engine(engine_type, engine_capacity, engine_horsepower, engine_milage))
        {
            type = pType;
            setVType(VEHICLE_TYPE.MOTORCYCLE);
        }

        public Motorcycle() : base()
        {
            setVType(VEHICLE_TYPE.MOTORCYCLE);
        }
    }
}
