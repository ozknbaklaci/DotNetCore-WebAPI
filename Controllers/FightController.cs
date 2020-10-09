using System.Threading.Tasks;
using DotNetCore_WebAPI.Dtos.Fight;
using DotNetCore_WebAPI.Services.FightService;
using Microsoft.AspNetCore.Mvc;

namespace DotNetCore_WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FightController : ControllerBase
    {
        private readonly IFightService _fightService;

        public FightController(IFightService fightService)
        {
            _fightService = fightService;
        }

        [HttpPost("Weapon")]
        public async Task<IActionResult> AddCharacterSkill(WeaponAttackDto request)
        {
            return Ok(await _fightService.WeaponAttack(request));
        }
    }
}