using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace CIS174_TestCoreApp.Models
{
    public class ToDoContext : DbContext
    {
        public ToDoContext(DbContextOptions<ToDoContext> options) : base(options)
        {

        }

        public DbSet<ToDo> ToDos { get; set; }
        public DbSet<ToDoCategory> ToDoCategories { get; set; }
        public DbSet<Status> Statuses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ToDoCategory>().HasData(
                new ToDoCategory { ToDoCategoryId = "work", Name = "Work"},
                new ToDoCategory { ToDoCategoryId = "home", Name = "Home" },
                new ToDoCategory { ToDoCategoryId = "ex", Name = "Exercise" },
                new ToDoCategory { ToDoCategoryId = "shop", Name = "Shopping" },
                new ToDoCategory { ToDoCategoryId = "call", Name = "Contact" }
            );
            modelBuilder.Entity<Status>().HasData(
                new Status { StatusId = "open", Name = "Open"},
                new Status { StatusId = "closed", Name = "Completed"}
            );
        }
    }
}
