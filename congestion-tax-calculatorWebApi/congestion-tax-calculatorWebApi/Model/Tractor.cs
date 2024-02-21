namespace congestion_tax_calculatorWebApi.Model
{
    public class Tractor : IVehicle
    {
        public string GetVehicleType()
        {
            return TollFreeVehicles.Tractor.ToString();
        }
    }
}
