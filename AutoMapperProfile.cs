using System.Linq;
using AutoMapper;
using DotNetCore_WebAPI.Dtos.Character;
using DotNetCore_WebAPI.Dtos.Skill;
using DotNetCore_WebAPI.Dtos.Weapon;
using DotNetCore_WebAPI.Models;

namespace DotNetCore_WebAPI
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Character, GetCharacterDto>()
            .ForMember(dto => dto.Skills, c => c.MapFrom(c => c.CharacterSkill.Select(cs => cs.Skill)));
            CreateMap<AddCharacterDto, Character>();
            CreateMap<Weapon, GetWeaponDto>();
            CreateMap<Skill, GetSkillDto>();
        }
    }
}