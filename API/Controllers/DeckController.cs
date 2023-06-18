using AutoMapper;
using CardGame.API.Models;
using CardGame.Domain.Models;
using CardGame.Domain.Repositories.Interfaces;
using CardGame.Utilities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CardGame.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class DeckController : Controller
    {
        private IDeckRepository _DeckRepository;
        private IPileRepository _PileRepository;
        private ICardRepository _CardRepository;
        private IMapper _Mapper;

        public DeckController(
            IDeckRepository deckRepository,
            IPileRepository pileRepository,
            ICardRepository cardRepository, 
            IMapper mapper)
        {
            _DeckRepository = deckRepository;
            _PileRepository = pileRepository;
            _CardRepository = cardRepository;
            _Mapper = mapper;
        }

        /// <summary>
        /// Creates a discard pile and a draw pile. Shuffles the draw pile. 
        /// Draws one card, placing it in the discard pile. Then uses these piles to create a deck.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public JsonResult NewGame()
        {
            var drawPile = new Pile();
            drawPile.IsDrawPile = true;
            var allCards = _CardRepository.GetAllCards().ToList();
            allCards.Shuffle();

            var firstCard = allCards.First();
            allCards.Remove(firstCard);
            drawPile.Cards = allCards.Select(card => card.Signature).ToList();

            var discard = new Pile();
            discard.IsDiscardPile = true;
            discard.Cards.Add(firstCard.Signature);
            _PileRepository.SaveChanges();

            var deck = new Deck();
            deck.DrawPile = drawPile.Id;
            deck.DiscardPile = discard.Id;
            _DeckRepository.CreateDeck(deck);
            _DeckRepository.SaveChanges();

            var model = _Mapper.Map<Deck, DeckModel>(deck);

            return Json( new { deck = model });
        }

        /// <summary>
        /// Takes an id and retrieves a deck, passing back the deck model as a json object.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public JsonResult GetDeck(int id)
        {
            var deck = _DeckRepository.GetDeckById(id);
            var model = _Mapper.Map<Deck, DeckModel>(deck);

            return Json(new { deck = model });
        }

        /// <summary>
        /// Takes a deck id and sets the deck to inactive, ending the game for that deck.
        /// </summary>
        /// <param name="deckId"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult EndGame(int deckId)
        {
            var deck = _DeckRepository.GetDeckById(deckId);
            deck.IsActive = false;
            _DeckRepository.SaveChanges();

            return Json(new { success = true });
        }

        /// <summary>
        /// Takes user guess and returns the next drawn card, with a server validated result.
        /// </summary>
        /// <param name="isHigher"></param>
        /// <param name="isLower"></param>
        /// <param name="deckId"></param>
        /// <returns></returns>
        /// <exception cref="InvalidDataException"></exception>
        [HttpPost]
        public JsonResult SubmitGuess(bool isHigher, bool isLower, int deckId)
        {
            var deck = _DeckRepository.GetDeckById(deckId);
            if (deck == null)
            {
                throw new InvalidDataException(nameof(deck));
            }

            var piles = _PileRepository.GetDeckPiles(deck);
            if (piles == null)
            {
                throw new InvalidDataException(nameof(deck));
            }

            var drawPile = piles.FirstOrDefault(p => p.IsDrawPile);
            if (drawPile == null) 
            {
                throw new InvalidDataException(nameof(drawPile));
            }
           
            var discardPile = piles.FirstOrDefault(p => p.IsDiscardPile);
            if (discardPile == null)
            {
                throw new InvalidDataException(nameof(discardPile));
            }

            //Assume that if the previous checks have all passed that the following are valid
            var drawCardSignature = drawPile.Cards.FirstOrDefault();
            var drawCard = _CardRepository.GetCardBySignature(drawCardSignature);
            var previousCardSignature = discardPile.Cards.LastOrDefault();
            var previousCard = _CardRepository.GetCardBySignature(previousCardSignature);

            var cardModel = _Mapper.Map<Card, CardModel>(drawCard);
            var drawCardIsHigher = drawCard.Value > previousCard.Value;
            var drawCardIsLower = drawCard.Value < previousCard.Value;
            var correctGuess = false;
            if (isHigher && drawCardIsHigher || isLower && drawCardIsLower)
            {
                correctGuess = true;
            }

            drawPile.Cards.Remove(drawCardSignature);
            discardPile.Cards.Add(drawCardSignature);
            _PileRepository.SaveChanges();

            return Json(new { correct = correctGuess, model = cardModel });
        }
    }
}
