namespace congestion_tax_calculatorWebApi.Model
{
    public class DiplomatVehicle : IVehicle
    {
        public string GetVehicleType()
        {
            return TollFreeVehicles.Diplomat.ToString();
        }
    }
}
