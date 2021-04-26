using Microsoft.EntityFrameworkCore;
using MovieRatingApp.Database;

namespace MovieRatingApp.EF
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options) : base(options) {}

        public DbSet<Content> Contents { get; set; }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Cast> Casts { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
