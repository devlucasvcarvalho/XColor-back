using Microsoft.EntityFrameworkCore;

namespace UserApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Models.UsuarioModel> Usuarios { get; set; }
    }
}
