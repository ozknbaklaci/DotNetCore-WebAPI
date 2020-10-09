using AutoMapper;
using DotNetCore_WebAPI.Dtos.Character;
using DotNetCore_WebAPI.Dtos.Weapon;
using DotNetCore_WebAPI.Models;

namespace DotNetCore_WebAPI
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Character, GetCharacterDto>();
            CreateMap<AddCharacterDto, Character>();
            CreateMap<Weapon, GetWeaponDto>();
        }
    }
}