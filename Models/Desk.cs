namespace MegaDesk_ASP.NET_Core.Models
{
    public class Desk
    {
        public int ID { get; set; }
        public required string Name { get; set; }
        public int Width { get; set; }
        public int Depth { get; set; }
        public int NumberOfDrawers { get; set; }
        public required string SurfaceMaterial { get; set; }
    }
}
