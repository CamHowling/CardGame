using CardGame.Database;
using CardGame.Domain.Models;
using CardGame.Domain.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CardGame.Domain.Repositories
{
    public class PileRepository : IPileRepository
    {
        private DatabaseContext _Context;

        public PileRepository(DatabaseContext context)
        {
            _Context = context;
        }

        public IEnumerable<Pile> GetDeckPiles(Deck deck)
        {
            return _Context.Piles.ToList();
        }

        public void CreatePile(Pile pile)
        {
            if (pile == null)
            {
                throw new ArgumentException(nameof(pile));
            }

            _Context.Piles.Add(pile);
        }

        public bool SaveChanges()
        {
            return (_Context.SaveChanges() >= 0);
        }
    }
}
