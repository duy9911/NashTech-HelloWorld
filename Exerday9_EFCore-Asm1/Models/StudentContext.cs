using CoreAPI_ASM2.Models;
using Microsoft.EntityFrameworkCore;

namespace CoreAPI_ASM2.Models
{
     public class StudentContext : DbContext
    {
        public StudentContext(DbContextOptions options) : base(options)
        {  
           
        }
        public DbSet<Student> Student { set; get; }
    }
}