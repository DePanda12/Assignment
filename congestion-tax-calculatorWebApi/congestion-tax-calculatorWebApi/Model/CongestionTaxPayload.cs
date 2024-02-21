using System.ComponentModel.DataAnnotations;

namespace congestion_tax_calculatorWebApi.Model
{
    public class CongestionTaxPayload
    {
        
        [Required]
        public string Vehicle { get; set; }

      

        [Required]
        public string[] Dates { get; set; }
    }
}
