using Microsoft.EntityFrameworkCore;
namespace Mvc_Mugdha_Maam.Models
{
    public class EmpDbContext:DbContext
    {
        public DbSet<Emp> emps { get; set; }//Bucket for catching Whatever Dbcontext brings from DB and Insert queries will taken from this bucket
        public EmpDbContext(DbContextOptions options):base(options)
        {

        }

    }
}
