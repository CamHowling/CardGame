using AutoMapper;
using CardGame.API.Models;
using CardGame.Domain.Models;

namespace CardGame.Domain.Profiles
{
    public class DeckProfile : Profile
    {
        public DeckProfile() 
        {
            CreateMap<Deck, DeckModel>();
            CreateMap<DeckModel, Deck>();
        }
    }
}
