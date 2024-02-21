namespace congestion_tax_calculatorWebApi.Model
{
    public class ForeignVehicle : IVehicle
    {
        public string GetVehicleType()
        {
            return TollFreeVehicles.Foreign.ToString();
        }
    }
}
