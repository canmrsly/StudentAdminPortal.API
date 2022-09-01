using Microsoft.EntityFrameworkCore;

namespace StudentAdminPortal.API.DataModels
{
    public class StudentAdminContext:DbContext
    {
        public StudentAdminContext(DbContextOptions<StudentAdminContext>options):base(options)
        {

        }
        public DbSet<Student> Student { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<Adress> Adress { get; set; }
    }
}
