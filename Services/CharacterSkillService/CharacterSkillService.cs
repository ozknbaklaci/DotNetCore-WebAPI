using System;
using System.Security.Claims;
using System.Threading.Tasks;
using AutoMapper;
using DotNetCore_WebAPI.Data;
using DotNetCore_WebAPI.Dtos.Character;
using DotNetCore_WebAPI.Dtos.CharacterSkill;
using DotNetCore_WebAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace DotNetCore_WebAPI.Services.CharacterSkillService
{
    public class CharacterSkillService : ICharacterSkillService
    {
        private readonly DataContext _context;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IMapper _mapper;

        public CharacterSkillService(IMapper mapper, DataContext context, IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
            _context = context;
            _mapper = mapper;
        }

        private int GetUserId() => int.Parse(_httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier));

        public async Task<ServiceResponse<GetCharacterDto>> AddCharacterSkill(AddCharacterSkillDto newCharacterSkill)
        {
            ServiceResponse<GetCharacterDto> response = new ServiceResponse<GetCharacterDto>();

            try
            {
                Character character = await _context.Characters
                .Include(c => c.Weapon)
                .Include(c => c.CharacterSkill)
                .ThenInclude(cs => cs.Skill)
                .FirstOrDefaultAsync
                (
                    c => c.Id == newCharacterSkill.CharacterId &&
                    c.User.Id == GetUserId()
                );

                if (character == null)
                {
                    response.Success = false;
                    response.Message = "Character not found";

                    return response;
                }

                Skill skill = await _context.Skills.FirstOrDefaultAsync(s => s.Id == newCharacterSkill.SkillId);

                if (skill == null)
                {
                    response.Success = false;
                    response.Message = "Skill not found";

                    return response;
                }

                CharacterSkill characterSkill = new CharacterSkill
                {
                    Character = character,
                    Skill = skill
                };

                await _context.CharacterSkills.AddAsync(characterSkill);
                await _context.SaveChangesAsync();

                response.Data = _mapper.Map<GetCharacterDto>(character);

                return response;

            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = ex.Message;

                return response;
            }
        }
    }
}