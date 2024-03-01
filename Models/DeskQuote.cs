namespace MegaDesk_ASP.NET_Core.Models
{
    public class DeskQuote
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Width { get; set; }
        public int Depth { get; set; }
        public int NumberOfDrawers { get; set; }
        public required string SurfaceMaterial { get; set; }
        public int RushDays { get; set; }
        public int QuoteAmount { get; set; }

        public List<String> AllowedMaterials { get; } = new List<string> { "Oak", "Maple", "Cherry" };
    }
}
