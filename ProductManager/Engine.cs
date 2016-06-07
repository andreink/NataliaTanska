using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManager
{
    enum ENGINE_TYPE : ushort
    {
        DIESEL = 0,
        PETROL = 1,
        HYBRID = 2
    }

    class Engine
    {
        public ENGINE_TYPE type;
        public string getType()
        {
            switch (type)
            {
                case ENGINE_TYPE.DIESEL:
                    return "DIESEL";
                case ENGINE_TYPE.PETROL:
                    return "PETROL";
                case ENGINE_TYPE.HYBRID:
                    return "HYBRID";
            }
            return "PETROL";
        }

        public void setType(ENGINE_TYPE what)
        {
            type = what;
        }
        public double capacity { get; set; }            // pojemność
        public uint horsepower { get; set; }             // ilość koni
        public uint milage { get; set; }                // przebieg

        public Engine(string pType, double pCapacity, uint pHorsepower, uint pMilage)
        {
            ENGINE_TYPE result;
            if (!Enum.TryParse(pType, out result))
            {
                throw new Exception("Zły typ silnika, dostępne wartości to DIESEL, PETROL, HYBRID.");
            }
            else
            {
                type = result;
            }
            capacity = pCapacity;
            horsepower = pHorsepower;
            milage = pMilage;
        }
    }
}
