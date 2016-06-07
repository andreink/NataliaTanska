using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManager
{
    class Truck : AbstractAutomobile
    {
        public ushort max_load { get; set; }       // maksymalny ładunek
        public ushort no_trailers { get; set; }    //ilość przyczep 
        public Truck(string pName, ushort pNo_wheels, bool pWheel_right, uint pPrice, ushort pLoad, ushort pTrailers, string engine_type, double engine_capacity, uint engine_horsepower, uint engine_milage) :
            base(pName, pNo_wheels, pWheel_right, pPrice, new Engine(engine_type, engine_capacity, engine_horsepower, engine_milage))
        {
            max_load = pLoad;
            no_trailers = pTrailers;
            setVType(VEHICLE_TYPE.TRUCK);
        }
        public Truck() : base()
        {
            setVType(VEHICLE_TYPE.TRUCK);

        }
    }
}
