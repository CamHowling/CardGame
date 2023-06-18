using AutoMapper;
using CardGame.API.Models;
using CardGame.Domain.Models;

namespace CardGame.Domain.Profiles
{
    public class PileProfile : Profile
    {
        public PileProfile() 
        {
            CreateMap<Pile, PileModel>();
            CreateMap<PileModel, Pile>();
        }
    }
}
