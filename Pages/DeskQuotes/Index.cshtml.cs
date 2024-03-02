using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MegaDesk_ASP.NET_Core.Data;
using MegaDesk_ASP.NET_Core.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MegaDesk_ASP.NET_Core.Pages.DeskQuotes
{
    public class IndexModel : PageModel
    {
        private readonly MegaDesk_ASP.NET_Core.Data.MegaDesk_ASPNET_CoreContext _context;

        public IndexModel(MegaDesk_ASP.NET_Core.Data.MegaDesk_ASPNET_CoreContext context)
        {
            _context = context;
        }

        public IList<DeskQuote> DeskQuote { get;set; } = default!;

        [BindProperty(SupportsGet = true)]
        public string? SearchString { get; set; }

        [BindProperty(SupportsGet = true)]
        public string? SortOrder { get; set; }

        public async Task OnGetAsync()
        {
            var deskQuotes = from d in _context.DeskQuote
                             select d;
            if (!string.IsNullOrEmpty(SearchString))
            {
                deskQuotes = deskQuotes.Where(s => EF.Functions.Like(s.Name, $"%{SearchString}%"));
            }

            switch (SortOrder)
            {
                case "name_desc":
                    deskQuotes = deskQuotes.OrderByDescending(s => s.Name);
                    break;
                case "date_asc":
                    deskQuotes = deskQuotes.OrderBy(s => s.orderedDate);
                    break;
                case "date_desc":
                    deskQuotes = deskQuotes.OrderByDescending(s => s.orderedDate);
                    break;
                default:
                    deskQuotes = deskQuotes.OrderBy(s => s.Name);
                    break;
            }

            DeskQuote = await deskQuotes.ToListAsync();
        }
    }
}
