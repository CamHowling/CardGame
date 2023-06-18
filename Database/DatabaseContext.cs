using CardGame.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace CardGame.Database
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }

        public DbSet<Deck> Decks { get; set; }
        public DbSet<Pile> Piles { get; set; }
        public DbSet<Card> Cards { get; set; }
    }
}
