using eTickets.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Data
{
    public class AppDbContext : IdentityDbContext<ApplicationUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options ) : base(options)
        {
            Database.EnsureCreated();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Actor_Movie>().HasKey(am => new
            {
                am.ActorId,
                am.MovieId
            });
            modelBuilder.Entity<Actor_Movie>().HasOne(m=>m.Movie).WithMany(am=>am.Actors_Movies).HasForeignKey(m=>
              m.MovieId);
            modelBuilder.Entity<Actor_Movie>().HasOne(m => m.Actor).WithMany(am => am.Actor_Movies).HasForeignKey(m => m.ActorId);

            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Actor> Actors { get; set; } = null;
        public DbSet<Movie> Movies { get; set; } = null;
        public DbSet<Actor_Movie> Actors_Movies { get; set; } = null;
        public DbSet<Cinema> Cinemas { get; set; } = null;
        public DbSet<Producer> Producers { get; set; } = null;

        //Orders related tables
        public DbSet<Order> Orders { get; set; } = null;
        public DbSet<OrderItem> OrderItems { get; set; } = null;

        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; } = null;
    }
}
