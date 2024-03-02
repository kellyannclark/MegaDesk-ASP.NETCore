using System.ComponentModel.DataAnnotations;

namespace MegaDesk_ASP.NET_Core.Models
{
    public class DeskQuote
    {
        public int ID { get; set; }

        [Display(Name = "Ordered Date")]
        [DataType(DataType.Date), Required]
        public DateTime orderedDate { get; set; }
        public required string Name { get; set; }

        [Range(24, 96), Required]
        public int Width { get; set; }
        [Range(12, 48), Required]
        public int Depth { get; set; }

        [Range(0, 7)]
        [Display(Name = "Number of Drawers"), Required]
        public int NumberOfDrawers { get; set; }

        [Display(Name = "Surface Material"), Required]
        public required string SurfaceMaterial { get; set; }

        [Display(Name = "Rush Days"), Required]
        public int RushDays { get; set; }

        [Display(Name = "Quoted Price")]
        public int QuoteAmount { get; set; }

        public List<String> AllowedMaterials { get; } = new List<string> { "Laminate", "Oak", "Rosewood", "Veneer", "Pine" };

        public int GetQuote()
        {
            int basePrice = 200;
            int surfaceArea = Width * Depth;
            int surfacePrice = 0;
            int drawerPrice = 50 * NumberOfDrawers;
            int rushPrice = 0;

            if (surfaceArea > 1000)
            {
                surfacePrice = surfaceArea - 1000;
            }

            switch (SurfaceMaterial)
            {
                case "Laminate":
                    surfacePrice += 100;
                    break;
                case "Oak":
                    surfacePrice += 200;
                    break;
                case "Rosewood":
                    surfacePrice += 300;
                    break;
                case "Veneer":
                    surfacePrice += 125;
                    break;
                case "Pine":
                    surfacePrice += 50;
                    break;
            }

            if (RushDays != 14)
            {
                if (surfaceArea < 1000)
                {
                    if (RushDays == 3)
                    {
                        rushPrice = 60;
                    }
                    else if (RushDays == 5)
                    {
                        rushPrice = 40;
                    }
                    else if (RushDays == 7)
                    {
                        rushPrice = 30;
                    }
                }
                else if (surfaceArea >= 1000 && surfaceArea <= 2000)
                {
                    if (RushDays == 3)
                    {
                        rushPrice = 70;
                    }
                    else if (RushDays == 5)
                    {
                        rushPrice = 50;
                    }
                    else if (RushDays == 7)
                    {
                        rushPrice = 35;
                    }
                }
                else
                {
                    if (RushDays == 3)
                    {
                        rushPrice = 80;
                    }
                    else if (RushDays == 5)
                    {
                        rushPrice = 60;
                    }
                    else if (RushDays == 7)
                    {
                        rushPrice = 40;
                    }
                }
            }

            return basePrice + surfacePrice + drawerPrice + rushPrice;
        }
    }
}
