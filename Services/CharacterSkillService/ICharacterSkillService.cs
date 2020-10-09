using System.Threading.Tasks;
using DotNetCore_WebAPI.Dtos.Character;
using DotNetCore_WebAPI.Dtos.CharacterSkill;
using DotNetCore_WebAPI.Models;

namespace DotNetCore_WebAPI.Services.CharacterSkillService
{
    public interface ICharacterSkillService
    {
        Task<ServiceResponse<GetCharacterDto>> AddCharacterSkill(AddCharacterSkillDto newCharacterSkill);
    }
}