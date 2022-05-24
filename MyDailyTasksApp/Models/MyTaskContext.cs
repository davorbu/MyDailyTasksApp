using Microsoft.EntityFrameworkCore;

namespace MyDailyTasksApp.Models
{
    public class MyTaskContext: DbContext
    {
        public MyTaskContext(DbContextOptions<MyTaskContext> options )
            : base(options) 
        {
            
        }
        public DbSet<ToDo> ToDos { get; set; }

        public DbSet<Status> Statuses { get; set; }
        public DbSet <Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = "work", Name = "Work"},
                new Category { CategoryId = "home", Name = "Home" },
                new Category { CategoryId = "ex", Name = "Exercise" },
                new Category { CategoryId = "shop", Name = "Shopping" },
                new Category { CategoryId = "contact", Name = "Contact" }
                );

            modelBuilder.Entity<Status>().HasData(
                new Status { StatusId = "open", Name ="Open"},
                new Status { StatusId ="closed", Name = "Completed"}
                );
        }


    }
}
