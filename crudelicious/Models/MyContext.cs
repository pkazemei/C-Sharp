using Microsoft.EntityFrameworkCore;
namespace crudelicious.Models
{ 
    // the MyContext class representing a session with our MySQL 
    // database allowing us to query for or save data
    public class MyContext : DbContext 
    { 
        public MyContext(DbContextOptions options) : base(options) { }
        // The models of your namespace
        public DbSet<Dish> Dish { get; set; }
        // More models, if necessary go here
    }
}
