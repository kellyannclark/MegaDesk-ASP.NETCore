namespace MegaDesk_ASP.NET_Core.Models
{
    public class DeskQuote
    {
        public int ID { get; set; }
        public string Name { get; set; }

        private readonly ILogger<DeskQuote> _logger;
        public Desk Desk { get; set; }
        public int RushDays { get; set; }
        public int QuoteAmount { get; set; }

        public DeskQuote(ILogger<DeskQuote> logger)
        {
            _logger = logger;
        }
    }
}
