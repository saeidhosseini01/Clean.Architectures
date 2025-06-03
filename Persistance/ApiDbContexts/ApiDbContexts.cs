using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Text;
using System.Threading.Tasks;
using Clean.Architecture.Domain.Entities.User;
using Clean.Architecture.Domain.Entities.Common;





namespace Clean.Architecture.Persistence.ApiDbContext
{



    public class ApiDbContexts(DbContextOptions<ApiDbContexts> options):DbContext(options)
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(user =>
            {
                user.ToTable("Users", schema: "AUTH");
                user.Property(e => e.Id).ValueGeneratedOnAdd();
                user.HasKey(e => e.Id);
            });
            modelBuilder.Entity<Const>(entity =>
            {
                entity.ToTable("Const", schema: "CNT");
                entity.Property(e => e.Id);
                entity.HasKey(e => e.Id);
            });
            modelBuilder.Entity<ConstType>(entity =>
            {
                entity.ToTable("ConstType", schema: "CNT");
                entity.Property(e => e.Id);
                entity.HasKey(e => e.Id);
            });
        }
        public DbSet<User> User { get; set; }
        public DbSet<Const> Const { get; set; }
        public DbSet<ConstType> ConstType{ get; set; }
    }
}
