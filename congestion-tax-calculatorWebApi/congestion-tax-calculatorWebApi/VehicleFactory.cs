using congestion_tax_calculatorWebApi.Model;

namespace congestion_tax_calculatorWebApi
{
    public class VehicleFactory
    {
        public static IVehicle CreateVehicle(string vehicleType)
        {
            switch (vehicleType.ToLower())
            {
                case "car":
                    return new Car();
                case "motorcycle":
                    return new MotorCycle();
                case "diplomat":
                    return new DiplomatVehicle();
                case "military":
                    return new MilitaryVehicle();
                case "tractor":
                    return new Tractor();
                case "foreign":
                    return new ForeignVehicle();
                case "emergency":
                    return new EmergencyVehicle();
                case "bus":
                    return new Bus();
                default:
                    throw new ArgumentException("Unknown vehicle type.", nameof(vehicleType));
            }
        }
    }
}

