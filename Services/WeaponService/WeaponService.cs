using System;
using System.Security.Claims;
using System.Threading.Tasks;
using AutoMapper;
using DotNetCore_WebAPI.Data;
using DotNetCore_WebAPI.Dtos.Character;
using DotNetCore_WebAPI.Dtos.Weapon;
using DotNetCore_WebAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace DotNetCore_WebAPI.Services.WeaponService
{
    public class WeaponService : IWeaponService
    {
        private readonly DataContext _context;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IMapper _mapper;

        public WeaponService(DataContext context, IHttpContextAccessor httpContextAccessor, IMapper mapper)
        {
            _context = context;
            _httpContextAccessor = httpContextAccessor;
            _mapper = mapper;
        }


        private int GetUserId() => int.Parse(_httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier));
        public async Task<ServiceResponse<GetCharacterDto>> AddWeapon(AddWeaponDto newWeapon)
        {
            ServiceResponse<GetCharacterDto> response = new ServiceResponse<GetCharacterDto>();

            try
            {
                Character character = await _context.Characters.FirstOrDefaultAsync(
                c => c.Id == newWeapon.CharacterId &&
                c.User.Id == GetUserId());

                if (character == null)
                {
                    response.Success = false;
                    response.Message = "Character not found";

                    return response;
                }

                Weapon weapon = new Weapon
                {
                    Name = newWeapon.Name,
                    Damage = newWeapon.Damage,
                    Character = character
                };

                 await _context.Weapons.AddAsync(weapon);
                 await _context.SaveChangesAsync();

               response.Data = _mapper.Map<GetCharacterDto>(character);

            }
            catch (Exception ex)
            {

                response.Success = false;
                response.Message = ex.Message;
            }
            return response;
        }
    }
}