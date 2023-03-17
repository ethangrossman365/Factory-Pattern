using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternVehicles
{
    public class ThreeWheeler : IVehicle
    {
        public ThreeWheeler() 
        {
        }

        public void Drive()
        {
            Console.WriteLine("Three wheeler's look cool.");
        }
    }
}
