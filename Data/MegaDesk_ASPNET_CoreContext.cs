using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MegaDesk_ASP.NET_Core.Models;

namespace MegaDesk_ASP.NET_Core.Data
{
    public class MegaDesk_ASPNET_CoreContext : DbContext
    {
        public MegaDesk_ASPNET_CoreContext (DbContextOptions<MegaDesk_ASPNET_CoreContext> options)
            : base(options)
        {
        }

        public DbSet<MegaDesk_ASP.NET_Core.Models.DeskQuote> DeskQuote { get; set; } = default!;
    }
}
