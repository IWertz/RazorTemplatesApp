using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CIS174_TestCoreApp.Models
{
    public class RegistrationModelContext : DbContext
    {
        public RegistrationModelContext(DbContextOptions<RegistrationModelContext> options) : base(options)
        {

        }
        public DbSet<RegistrationModel> Tickets { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<RegistrationModel>().HasData(
                new RegistrationModel {
                    RegistrationModelId = 1,
                    Name = "John Doe",
                    Address = "123 This Street",
                    Phone = "515-555-1234",
                    Email = "jdoe@gmail.com",
                    Age = 17,
                    Contact = "By Phone"
                }
            );
        }
    }
}
