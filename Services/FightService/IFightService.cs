using System.Threading.Tasks;
using DotNetCore_WebAPI.Dtos.Fight;
using DotNetCore_WebAPI.Models;

namespace DotNetCore_WebAPI.Services.FightService
{
    public interface IFightService
    {
        Task<ServiceResponse<AttackResultDto>> WeaponAttack(WeaponAttackDto request);
    }
}