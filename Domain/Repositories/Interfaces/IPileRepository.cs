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
        /// Create a new pile item in the database
        /// </summary>
        /// <param name="pile"></param>
        public void CreatePile(Pile pile);

        /// <summary>
        /// Save pending changes to the database
        /// </summary>
        /// <returns></returns>
        public bool SaveChanges();
    }
}
