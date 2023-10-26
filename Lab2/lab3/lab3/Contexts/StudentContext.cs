using Microsoft.EntityFrameworkCore;
using lab3.Models;
namespace lab3.Contexts
{
    public class StudentContext : DbContext
    {
        /*public StudentContext(DbContextOptions<StudentContext> options) : base(options)
        {
        }*/
        public DbSet<Student> Students { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=oliadkuxrl9xdugh.chr7pe7iynqr.eu-west-1.rds.amazonaws.com;database=?;uid=xxqoce5l5wo71zrx;pwd=ev1oklioc68s9fgr;");
        }
    }
}
