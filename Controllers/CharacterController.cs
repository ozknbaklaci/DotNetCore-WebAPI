using System.Collections.Generic;
using System.Linq;
using DotNetCore_WebAPI.Models;
using DotNetCore_WebAPI.Services.CharacterService;
using Microsoft.AspNetCore.Mvc;

namespace DotNetCore_WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CharacterController : ControllerBase
    {
        private readonly ICharacterService _characterService;

        public CharacterController(ICharacterService characterService)
        {
            _characterService = characterService;
        }

        [HttpGet("GetAll")]
        public IActionResult Get()
        {
            return Ok(_characterService.GetAllCharacters());
        }

        [HttpGet("{id}")]
        public IActionResult GetSingle(int id)
        {
            return Ok(_characterService.GetCharacterById(id));
        }
        
        [HttpPost]
        public IActionResult AddCharacter(Character character)
        {
            return Ok(_characterService.AddCharacter(character));
        }
    }
}