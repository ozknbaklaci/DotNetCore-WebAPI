using System.Collections.Generic;
using System.Threading.Tasks;
using DotNetCore_WebAPI.Dtos.Fight;
using DotNetCore_WebAPI.Models;

namespace DotNetCore_WebAPI.Services.FightService
{
    public interface IFightService
    {
        Task<ServiceResponse<AttackResultDto>> WeaponAttack(WeaponAttackDto request);
        Task<ServiceResponse<AttackResultDto>> SkillAttack(SkillAttackDto request);
        Task<ServiceResponse<FightResultDto>> Fight(FightRequestDto request);
        Task<ServiceResponse<List<HighScoreDto>>> GetHighScore();
    }
}