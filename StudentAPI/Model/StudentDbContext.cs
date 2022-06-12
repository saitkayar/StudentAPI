using Microsoft.EntityFrameworkCore;

namespace StudentAPI.Model
{
    public class StudentDbContext:DbContext
    {
        public StudentDbContext(DbContextOptions<StudentDbContext> options):base(options)
        {

        }

        public DbSet<Student> Student { get; set; }
        public DbSet<Gender> Gender { get; set; }
        public DbSet<Adress> Adress { get; set; }
    }
}
