using IBM.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebApplicationMVCAPI1.Mapping;
using WebApplicationMVCAPI1.Models;

namespace WebApplicationMVCAPI1.Context
{
    public class InformixContext :DbContext
    {
        public DbSet<Cidade> Cidades { get; set; }

        public DbSet<Estado> Estados { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseDb2("Server=127.0.0.1:5125;Database=banco;Uid=tiwebapps;Pwd=senha;",
            options => options.SetServerInfo(IBMDBServerType.IDS, IBMDBServerVersion.IDS_11_70_8000));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CidadeConfiguration());
            modelBuilder.ApplyConfiguration(new EstadoConfiguration());
        }
    }
}
