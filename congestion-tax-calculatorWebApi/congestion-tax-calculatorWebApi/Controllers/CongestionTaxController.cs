using congestion_tax_calculatorWebApi.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;

using System;

namespace congestion_tax_calculatorWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CongestionTaxController : ControllerBase
    {
        private readonly CongestionTaxDbContext _dbContext;

        private readonly ILogger<CongestionTaxController> _logger;
        public CongestionTaxController(ILogger<CongestionTaxController> logger)
        {
            _dbContext = new();
            _logger = logger;
        }

        [HttpPost(Name = "CongestionTax")]
        public int Post([FromBody] CongestionTaxPayload payload)
        {
            var vehicle = VehicleFactory.CreateVehicle(payload.Vehicle);
            List<DateTime> dateTimes = new();
            foreach (var date in payload.Dates)
            {
                DateTime dateTime;
                if (DateTime.TryParseExact(date, "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None, out dateTime))
                {
                    dateTimes.Add(dateTime);
                    Console.WriteLine("Parsed DateTime: " + dateTime.ToString());
                }
                else
                {
                    Console.WriteLine("Failed to parse DateTime.");
                }
            }
            return _dbContext.CalculateTax(vehicle, dateTimes);
        }
    }
}