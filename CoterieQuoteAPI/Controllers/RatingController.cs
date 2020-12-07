using CoterieAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;

namespace CoterieAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class RatingController : Controller
    {
        private readonly ILogger<RatingController> _logger;
        private readonly IConfiguration _config;

        public RatingController(ILogger<RatingController> logger, IConfiguration configuration)
        {
            _logger = logger;
            _config = configuration;
        }

        [HttpPost]
        [Route("GetBusinessPremiumQuote")]
        public BusinessPremiumQuoteResponse GetBusinessPremium(BusinessPremiumQuoteRequest quoteRequest)
        {
            var businessPremiumQuoteResponse = new BusinessPremiumQuoteResponse();
            var factorConfig = _config.GetSection("Lookups");

            var configStateFactor = factorConfig[quoteRequest.State];
            decimal stateFactor = Convert.ToDecimal(configStateFactor);

            var configBusinessFactor = factorConfig[quoteRequest.Business];
            decimal businessFactor = Convert.ToDecimal(configBusinessFactor);

            var congigBasePremium = factorConfig["BasePremium"];
            decimal basePremium = Convert.ToDecimal(congigBasePremium);
            basePremium = quoteRequest.Revenue * basePremium;

            var configHazardFactor = factorConfig["HazardFactor"];
            decimal hazardFactor = Convert.ToDecimal(configHazardFactor);

            businessPremiumQuoteResponse.Premium = Convert.ToInt32(stateFactor * businessFactor * hazardFactor * basePremium);
            return businessPremiumQuoteResponse;
        }
    }
}
