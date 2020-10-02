using System.Collections.Generic;
using DotNetCore_WebAPI.Models;

namespace DotNetCore_WebAPI.Services.CharacterService
{
    public interface ICharacterService
    {
         List<Character> GetAllCharacters();
         Character GetCharacterById(int id);
          List<Character> AddCharacter(Character character);
    }
}