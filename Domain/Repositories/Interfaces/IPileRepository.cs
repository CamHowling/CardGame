using CardGame.Domain.Models;

namespace CardGame.Domain.Repositories.Interfaces
{
    public interface IPileRepository
    {
        /// <summary>
        /// Gets the discard and draw piles for a given deck
        /// </summary>
        /// <param name="deck"></param>
        /// <returns></returns>
        public IEnumerable<Pile> GetDeckPiles(Deck deck);

        /// <summary>
        /// Removes a card from the draw pile and places it in the discard pile
        /// </summary>
        /// <param name="drawPileId"></param>
        /// <param name="discardPileId"></param>
        /// <returns></returns>
        public IEnumerable<Pile> DrawCard(int drawPileId, int discardPileId);

        /// <summary>
        /// Save pending changes to the database
        /// </summary>
        /// <returns></returns>
        public bool SaveChanges();
    }
}
