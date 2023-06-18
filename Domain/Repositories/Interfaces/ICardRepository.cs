using CardGame.Domain.Models;

namespace CardGame.Domain.Repositories.Interfaces
{
    public interface ICardRepository
    {
        /// <summary>
        /// Returns a list of cards
        /// </summary>
        /// <returns></returns>
        IEnumerable<Card> GetAllCards();

        /// <summary>
        /// Takes a card signature and returns the associated card
        /// </summary>
        /// <param name="signature">Two character representation of a card</param>
        /// <returns></returns>
        Card GetCardBySignature(string signature);
    }
}
