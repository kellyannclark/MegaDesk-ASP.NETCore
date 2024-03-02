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
    public class DetailsModel : PageModel
    {
        private readonly MegaDesk_ASP.NET_Core.Data.MegaDesk_ASPNET_CoreContext _context;

        public DetailsModel(MegaDesk_ASP.NET_Core.Data.MegaDesk_ASPNET_CoreContext context)
        {
            _context = context;
        }

        public DeskQuote DeskQuote { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var deskquote = await _context.DeskQuote.FirstOrDefaultAsync(m => m.ID == id);
            if (deskquote == null)
            {
                return NotFound();
            }
            else
            {
                DeskQuote = deskquote;
            }
            return Page();
        }
    }
}
