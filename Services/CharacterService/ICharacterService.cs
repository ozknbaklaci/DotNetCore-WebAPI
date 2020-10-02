using System.Collections.Generic;
using System.Threading.Tasks;
using DotNetCore_WebAPI.Models;

namespace DotNetCore_WebAPI.Services.CharacterService
{
    public interface ICharacterService
    {
        Task<List<Character>> GetAllCharacters();
        Task<Character> GetCharacterById(int id);
        Task<List<Character>> AddCharacter(Character character);
    }
}