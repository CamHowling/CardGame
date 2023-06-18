using AutoMapper;
using CardGame.API.Models;
using CardGame.Domain.Models;

namespace CardGame.Domain.Profiles
{
    public class CardProfile : Profile
    {
        public CardProfile() 
        {
            CreateMap<Card, CardModel>();
            CreateMap<CardModel, Card>();
        }
    }
}
