using CardGame.Database;
using CardGame.Domain.Models;
using CardGame.Domain.Repositories.Interfaces;

namespace CardGame.Domain.Repositories
{
    public class CardRepository : ICardRepository
    {
        private DatabaseContext _Context;

        public CardRepository(DatabaseContext context) 
        {
            _Context = context;
        }

        public IEnumerable<Card> GetAllCards()
        {
            return _Context.Cards.ToList();
        }

        public Card GetCardBySignature(string signature)
        {
            if (signature == null)
            {
                throw new ArgumentNullException(nameof(signature));
            }

            var card = _Context.Cards.FirstOrDefault(card => card.Signature.Equals(signature));
            if (card == null) 
            {
                throw new KeyNotFoundException(nameof(signature));
            }

            return card;
        }
    }
}
