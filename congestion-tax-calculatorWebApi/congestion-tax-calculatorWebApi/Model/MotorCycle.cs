namespace congestion_tax_calculatorWebApi.Model
{
    public class MotorCycle : IVehicle
    {
        public string GetVehicleType()
        {
            return TollFreeVehicles.MotorCycle.ToString();
        }
    }
}