using Andreitoledo.SGC.Mvc.Models;
using Microsoft.EntityFrameworkCore;

namespace Andreitoledo.SGC.Mvc.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options)
            : base(options)
        {
        }

        public DbSet<Conferencia> Conferencia { get; set; }
    }
}
