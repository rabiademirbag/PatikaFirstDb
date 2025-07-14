using Microsoft.EntityFrameworkCore;
using PatikaFirstDb.Data.Entities;

namespace PatikaFirstDb.Data
{
    public class PatikaFirstDbContext:DbContext
    {

        //connection string program.cs den geliyor
        public PatikaFirstDbContext(DbContextOptions<PatikaFirstDbContext> options) : base(options) { }


        public DbSet<Game>Games { get; set; }
        public DbSet<Movie> Movies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Movie>(entity =>
            {
                entity.ToTable("Movies");
            });

            modelBuilder.Entity<Game>(entity =>
            {
                entity.ToTable("Games");
            });
        }
    }
}
