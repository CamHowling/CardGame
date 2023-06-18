using AutoMapper;
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


    }
}
