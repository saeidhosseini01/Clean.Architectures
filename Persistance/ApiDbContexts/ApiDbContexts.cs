using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Text;
using System.Threading.Tasks;
using Clean.Architecture.Domain.Entities;





namespace Clean.Architecture.Persistence.ApiDbContext
{


    public class ApiDbContexts(DbContextOptions<ApiDbContexts> options):DbContext(options)
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(user =>
            {
                user.Property(e => e.Id);
                user.HasKey(e => e.Id);
            });
        }
        public DbSet<User> User { get; set; }
    }
}
