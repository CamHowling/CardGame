using AutoMapper;
using CardGame.API.Models;
using CardGame.Domain.Models;
using CardGame.Domain.Repositories.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CardGame.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class DeckController : ControllerBase
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

        /*
         Actions:
            Submit Guess / Draw Card
                Correct guess +1 point
                Incorrect guess -1 point
            End Game
                //Can assume that score tracking will be handled by cookies...
                //this will set deck as inactive
            StartGame/NewDeck
                Get all the cards....

            GetDeck
                //Get active deck, return invalid if the deck has been finished
         */

        [HttpGet]
        public ActionResult<DeckModel> NewGame()
        {
            var drawPile = new Pile();
            var discard = new Pile();

            var deck = new Deck();
            _DeckRepository.CreateDeck(deck);
            _DeckRepository.SaveChanges();

            var model = _Mapper.Map<Deck>(deck);
            return Ok(model);
        }

        [HttpGet]
        public ActionResult<DeckModel> GetDeck(int id)
        {
            var deck = _DeckRepository.GetDeckById(id);
            var model = _Mapper.Map<Deck>(deck);
            return Ok(model);
        }

        [HttpPost]
        public ActionResult<CardModel> SubmitGuess(bool isHigher, int deckId)
        {
            var deck = _DeckRepository.GetDeckById(deckId);
            var piles = _PileRepository.GetDeckPiles(deck);
            var drawPile = piles.FirstOrDefault(p => p.IsDrawPile);
            var discardPile = piles.FirstOrDefault(p => p.IsDiscardPile);

            //remove first item from draw pile. 
            //Check against last item in discard pile.
            //Move to discard pile.
            //Save both piles.
            //Get the card model.
            //Return the card model 

        }
    }
}
