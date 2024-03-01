using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MegaDesk_ASP.NET_Core.Data;
using MegaDesk_ASP.NET_Core.Models;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.View;

namespace MegaDesk_ASP.NET_Core.Pages.DeskQuotes
{
    public class IndexModel : PageModel
    {
        private readonly MegaDesk_ASP.NET_Core.Data.MegaDesk_ASPNET_CoreContext _context;
        private object context;

        public IndexModel(MegaDesk_ASP.NET_Core.Data.MegaDesk_ASPNET_CoreContext context)
        {
            _context = context;
        }

        public IList<DeskQuote> DeskQuote { get;set; } = default!;
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public SelectList Genres { get; set; }
        [BindProperty(SupportsGet = true)]
        public string MovieGenre { get; set; }
        public async Task OnGetAsync()
        {
            var DeskQuote = from m in context.DeskQuote
                            select m;
            if (!string.IsNullOrEmpty(SearchString))
            {
            DeskQuote = DeskQuote.Where(s => s.Title.Contains(SearchString));
            }

            DeskQuote = await _context.DeskQuote.ToListAsync();
        }
    }
}
