using CardGame.Domain.Models;
using CardGame.Domain.Repositories.Interfaces;

namespace CardGame.Domain.Repositories
{
    public class PileRepository : IPileRepository
    {
        public IEnumerable<Pile> DrawCard(int drawPileId, int discardPileId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Pile> GetDeckPiles(Deck deck)
        {
            throw new NotImplementedException();
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}
