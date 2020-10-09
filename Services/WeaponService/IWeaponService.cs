using System.Threading.Tasks;
using DotNetCore_WebAPI.Dtos.Character;
using DotNetCore_WebAPI.Dtos.Weapon;
using DotNetCore_WebAPI.Models;

namespace DotNetCore_WebAPI.Services.WeaponService
{
    public interface IWeaponService
    {
        Task<ServiceResponse<GetCharacterDto>> AddWeapon(AddWeaponDto newWeapon);
    }
}