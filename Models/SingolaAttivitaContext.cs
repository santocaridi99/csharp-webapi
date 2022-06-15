using Microsoft.EntityFrameworkCore;

namespace csharp_webapi.Models
{
    public class SingolaAttivitaContext : DbContext
    {
        public SingolaAttivitaContext(DbContextOptions<SingolaAttivitaContext> options) : base(options)
        {

        }
        public DbSet<SingolaAttivita> ListaAttivita { get; set; } = null!; 
    }
}
