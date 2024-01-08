using Microsoft.EntityFrameworkCore;
using StudentCrud.Models.Entities;

namespace StudentCrud.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext( DbContextOptions<ApplicationDbContext> options): base(options)
        {
            
        }


        public DbSet<Student> Students { get; set; }




    }
}
