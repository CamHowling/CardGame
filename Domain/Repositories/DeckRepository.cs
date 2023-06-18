using CardGame.Database;
using CardGame.Domain.Models;
using CardGame.Domain.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.Xml;

namespace CardGame.Domain.Repositories
{
    public class DeckRepository : IDeckRepository
    {
        private DatabaseContext _Context;

        public DeckRepository(DatabaseContext context)
        {
            _Context = context;
        }

        public void CreateDeck(Deck deck)
        {
            if (deck == null)
            {
                throw new ArgumentNullException(nameof(deck));
            }

            _Context.Decks.Add(deck);
        }

        public Deck GetDeckById(int id)
        {
            var deck = _Context.Decks.FirstOrDefault(deck => deck.Id == id);
            if (deck == null)
            {
                throw new KeyNotFoundException(nameof(id));
            }

            return deck;
        }

        public bool SaveChanges()
        {
            return (_Context.SaveChanges() >= 0);
        }
    }
}
