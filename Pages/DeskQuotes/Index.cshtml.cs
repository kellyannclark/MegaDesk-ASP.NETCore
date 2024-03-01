using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MegaDesk_ASP.NET_Core.Data;
using MegaDesk_ASP.NET_Core.Models;

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

        public async Task OnGetAsync()
        {
            DeskQuote = await _context.DeskQuote.ToListAsync();
        }
    }
}
