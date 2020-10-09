using System.Collections.Generic;

namespace DotNetCore_WebAPI.Models
{
    public class Skill
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Damage { get; set; }
        public List<CharacterSkill> CharacterSkill { get; set; }
    }
}