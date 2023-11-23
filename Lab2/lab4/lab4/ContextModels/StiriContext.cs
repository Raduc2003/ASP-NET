using lab4.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace lab4.ContextModels
{
    public class StiriContext:DbContext
    {
        public StiriContext(DbContextOptions<StiriContext> options):base(options)
        {
            
        }
        public DbSet<Stire> Stire { get; set; }
        public DbSet<Categorie> Categories { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categorie>()
                .HasKey(b => b.CategorieId);
            modelBuilder.Entity<Stire>()
                .HasKey(p => p.Id);
            modelBuilder.Entity<Stire>()
                .HasOne(p => p.Categorie)
                .WithMany(p=>p.Stiri)
                .HasForeignKey(p => p.CategorieFK);
        }
    }
}   
