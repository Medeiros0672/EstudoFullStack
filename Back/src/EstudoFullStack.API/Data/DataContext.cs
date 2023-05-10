using EstudoFullStack.API.Models;
using Microsoft.EntityFrameworkCore;

namespace EstudoFullStack.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Evento> Eventos { get; set; }

    }

}
