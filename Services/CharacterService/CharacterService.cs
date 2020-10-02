using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotNetCore_WebAPI.Models;

namespace DotNetCore_WebAPI.Services.CharacterService
{
    public class CharacterService : ICharacterService
    {
        private static List<Character> characters = new List<Character>
         {
            new Character(),
            new Character{Id = 1,Name = "Sam" }
        };
        public async Task<ServiceResponse<List<Character>>> AddCharacter(Character character)
        {
            ServiceResponse<List<Character>> serviceResponse = new ServiceResponse<List<Character>>();
            characters.Add(character);
            serviceResponse.Data = characters;

            return serviceResponse;
        }

        public async Task<ServiceResponse<List<Character>>> GetAllCharacters()
        {
            ServiceResponse<List<Character>> serviceResponse = new ServiceResponse<List<Character>>();
            serviceResponse.Data = characters;

            return serviceResponse;
        }

        public async Task<ServiceResponse<Character>> GetCharacterById(int id)
        {
            ServiceResponse<Character> serviceResponse = new ServiceResponse<Character>();
            serviceResponse.Data = characters.FirstOrDefault(c => c.Id == id);

            return  serviceResponse;
        }
    }
}