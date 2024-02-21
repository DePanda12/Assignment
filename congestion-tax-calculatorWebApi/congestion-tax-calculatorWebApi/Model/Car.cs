using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace congestion_tax_calculatorWebApi.Model
{
    public class Car : IVehicle
    {
        public string GetVehicleType()
        {
            return NoneTollFreeVehicles.Car.ToString();
        }
    }
}