using Microsoft.EntityFrameworkCore;

namespace EF_ASPCORE.Models
{
    public class StudentContext : DbContext
    {
        public StudentContext(DbContextOptions options) : base(options)
        {  
           
        }
        public DbSet<Student> Student { set; get; }
    }
}

