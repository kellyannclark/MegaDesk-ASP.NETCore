using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MegaDesk_ASP.NET_Core.Data;
using MegaDesk_ASP.NET_Core.Models;

namespace MegaDesk_ASP.NET_Core.Pages.DeskQuotes
{
    public class CreateModel : PageModel
    {
        private readonly MegaDesk_ASPNET_CoreContext _context;

        public CreateModel(MegaDesk_ASPNET_CoreContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            DeskQuote = new DeskQuote();
            return Page();
        }

        [BindProperty]
        public DeskQuote DeskQuote { get; set; } = default!;

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            DeskQuote.QuoteAmount = DeskQuote.GetQuote();
            _context.DeskQuote.Add(DeskQuote);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }

    }
}
