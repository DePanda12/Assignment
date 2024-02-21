namespace congestion_tax_calculatorWebApi.Model
{
    public class EmergencyVehicle : IVehicle
    {
        public string GetVehicleType()
        {
            return TollFreeVehicles.Emergency.ToString();
        }
    }
}
