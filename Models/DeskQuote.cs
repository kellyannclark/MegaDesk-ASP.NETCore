using System.ComponentModel.DataAnnotations;

namespace MegaDesk_ASP.NET_Core.Models
{
    public class DeskQuote
    {
        public int ID { get; set; }

        [Display(Name = "Ordered Date")]
        [DataType(DataType.Date)]
        public DateTime orderedDate { get; set; }
        public string Name { get; set; }

        [Range(24, 96)]
        public int Width { get; set; }
        [Range(12, 48)]
        public int Depth { get; set; }
        
        [Range(0, 7)]
        [Display(Name = "Number of Drawers")]
        public int NumberOfDrawers { get; set; }

        [Display(Name = "Surface Material")]
        public required string SurfaceMaterial { get; set; }

        [Display(Name = "Rush Days")]
        public int RushDays { get; set; }

        [Display(Name = "Quoted Price")]
        public int QuoteAmount { get; set; }

        public List<String> AllowedMaterials { get; } = new List<string> { "Laminate", "Oak", "Rosewood", "Veneer", "Pine" };
    }
}
