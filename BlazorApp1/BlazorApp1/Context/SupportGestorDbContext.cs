using BlazorApp1.MVVM.MODEL;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp1.Context
{
    public class SupportGestorDbContext : DbContext
    {
        public SupportGestorDbContext(DbContextOptions<SupportGestorDbContext> options) : base(options)
        {
            
        }
        public DbSet<Atendimentos> Atendimentos { get; set; }  
        public DbSet<Empresas> Empresas { get; set; }
        public DbSet<Clientes> Clientes { get; set; }
        public DbSet<Atendentes> Atendentes { get; set; }

    }
}
