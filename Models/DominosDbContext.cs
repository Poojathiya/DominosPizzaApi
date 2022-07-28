using Microsoft.EntityFrameworkCore;

namespace DominosPizza.Models
{
    public class DominosDbContext : DbContext
    {

        public DominosDbContext(DbContextOptions<DominosDbContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        public virtual DbSet<Pizza> Pizzas { get; set; }

    }


}
