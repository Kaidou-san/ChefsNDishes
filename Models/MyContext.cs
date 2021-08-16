using Microsoft.EntityFrameworkCore;

namespace ChefsNDishes.Models
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions options) : base(options) {}
        // dont forget to add ur DBSet here!!
        
        public DbSet<Dish> Dishes {get; set;}
        public DbSet<Chef> Chefs {get; set;}
        
    }
}