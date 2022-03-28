using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using projetoCurso.api.Infraestruture.Data;

namespace projetoCurso.api.Configurations
{
    public class DbFactoryDbContext : IDesignTimeDbContextFactory<CursoDbContext>
    {
        public CursoDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<CursoDbContext>();
            optionsBuilder.UseMySql("Server = localhost; Port = 3306; Database = projetocurso; Uid = root; Pwd = ");
            CursoDbContext contexto = new CursoDbContext(optionsBuilder.Options);

            return contexto;
        }
    }
}
