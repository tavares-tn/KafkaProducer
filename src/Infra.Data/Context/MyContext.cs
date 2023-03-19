using Domain.Entities;
using Infra.Data.Mapping;
using Microsoft.EntityFrameworkCore;

namespace Infra.Data.Context
{
    public class MyContext : DbContext
    {
        public DbSet<ExampleEntity> Examples { get; set; }

        public MyContext(DbContextOptions<MyContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ExampleEntity>(new ExampleMapping().Configure);
        }
    }
}
