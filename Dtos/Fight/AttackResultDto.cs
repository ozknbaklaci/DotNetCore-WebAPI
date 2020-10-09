namespace DotNetCore_WebAPI.Dtos.Fight
{
    public class AttackResultDto
    {
        public string Attacker { get; set; }
        public string Oppenent { get; set; }
        public int AttackerHP { get; set; }
        public int OppenentHP { get; set; }
        public int Damage { get; set; }
    }
}