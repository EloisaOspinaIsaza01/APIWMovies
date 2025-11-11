using APIWMovies.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace APIWMovies.DAL
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
        //Secciòn para crear el dbset de las entidades o modelos
        public DbSet<Category> Categories { get; set; }
    }
}
