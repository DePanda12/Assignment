namespace congestion_tax_calculatorWebApi.Model
{
    public class MilitaryVehicle : IVehicle
    {
        public string GetVehicleType()
        {
            return TollFreeVehicles.Military.ToString();
        }
    }
}
