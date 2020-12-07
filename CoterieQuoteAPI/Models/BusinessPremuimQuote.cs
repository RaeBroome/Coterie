namespace CoterieAPI.Models
{
    public class BusinessPremiumQuoteRequest
    {
        public decimal Revenue { get; set; }
        public string State { get; set; }
        public string Business { get; set; }
    }

    public class BusinessPremiumQuoteResponse
    {
        public decimal Premium { get; set; }
    }
}
