using System.Collections.Generic;

namespace DotNetCore_WebAPI.Models
{
    public class Character
    {
        public int Id { get; set; }
        public string Name { get; set; } = "Frodo";
        public int HitPoints { get; set; } = 100;
        public int Strength { get; set; } = 10;
        public int Defense { get; set; } = 10;
        public int Intelligence { get; set; } = 10;
        public RpgClass Class { get; set; } = RpgClass.Knigth;
        public User User { get; set; }
        public int UserId { get; set; }
        public Weapon Weapon { get; set; }
        public List<CharacterSkill> CharacterSkill { get; set; }
        public int Fights { get; set; }
        public int Victories { get; set; }
        public int Defeats { get; set; }
    }
}