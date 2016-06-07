using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManager
{
    enum VEHICLE_TYPE : ushort
    {
        CAR,
        TRUCK,
        MOTORCYCLE,
        OTHER
    }

    abstract class AbstractVehicle
    {
        public string name { get; set; }                // nazwa typów
        public ushort no_wheels { get; set; }              // ilość kół
        public bool wheel_right { get; set; }           // kierownica po prawej ?

        public bool has_engine { get; set; }
        public uint price { get; set; }

        protected VEHICLE_TYPE _vType;
        public void setVType(VEHICLE_TYPE what)
        {
            _vType = what;
        }

        public string getVType()
        {
            switch (_vType)
            {
                case VEHICLE_TYPE.CAR:
                    return "CAR";
                case VEHICLE_TYPE.MOTORCYCLE:
                    return "MOTORCYCLE";

                case VEHICLE_TYPE.TRUCK:
                    return "TRUCK";
            }
            return "OTHER";
        }
        protected AbstractVehicle(string pName, ushort pNo_wheels, bool pWheel_right, bool pHas_engine, uint pPrice)
        {
            name = pName;
            no_wheels = pNo_wheels;
            wheel_right = pWheel_right;
            has_engine = pHas_engine;
            price = pPrice;
        }
        public AbstractVehicle() : base()
        {

        }
    }
}
