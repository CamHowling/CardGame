using CardGame.Domain.Models;

namespace CardGame.Domain.Repositories.Interfaces
{
    public interface IDeckRepository
    {
        /// <summary>
        /// Returns the deck associated with a given id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Deck GetDeckById(int id);

        /// <summary>
        /// Create a new deck item in the database
        /// </summary>
        /// <param name="deck"></param>
        void CreateDeck(Deck deck);

        /// <summary>
        /// Save pending changes to the database
        /// </summary>
        /// <returns></returns>
        public bool SaveChanges();
    }
}
