using luafalcao.api.Persistence.Configurations;
using luafalcao.api.Persistence.Entities;
using Microsoft.EntityFrameworkCore;

namespace luafalcao.api.Persistence.Contexts
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new UsuarioConfiguration());
            builder.ApplyConfiguration(new EscolaridadeConfiguration());

            base.OnModelCreating(builder);
        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Escolaridade> Escolaridade { get; set; }
    }
}
