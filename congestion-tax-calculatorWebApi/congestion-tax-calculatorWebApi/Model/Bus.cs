namespace congestion_tax_calculatorWebApi.Model
{
    public class Bus : IVehicle
    {
        public string GetVehicleType()
        {
            return TollFreeVehicles.Bus.ToString();
        }
    }
}
