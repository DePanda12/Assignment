using congestion_tax_calculatorWebApi.Model;

namespace congestion_tax_calculatorWebApi
{
    //Not real database call for now
    public class CongestionTaxDbContext
    {
        public CongestionTaxCalculator CongestionTax { get; }
        public CongestionTaxDbContext()
        {

            CongestionTax = new CongestionTaxCalculator();
        }
        public int CalculateTax(IVehicle vehicle, List<DateTime> dates)
        {
            return CongestionTax.GetTax(vehicle, dates.ToArray());
        }

    }
}
