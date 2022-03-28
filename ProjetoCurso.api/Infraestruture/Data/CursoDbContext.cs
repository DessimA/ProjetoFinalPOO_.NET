using Microsoft.EntityFrameworkCore;
using projetoCurso.api.Business.Entities;
using projetoCurso.api.Infraestruture.Mappings;

namespace projetoCurso.api.Infraestruture.Data
{
    public class CursoDbContext: DbContext 
    {
        public CursoDbContext(DbContextOptions<CursoDbContext> options) :base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CursoMapping());
            modelBuilder.ApplyConfiguration(new UsuarioMapping());
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Usuario> Usuario { get; set; }
    }
}
