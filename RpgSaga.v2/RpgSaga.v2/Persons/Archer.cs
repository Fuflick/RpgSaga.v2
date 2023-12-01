namespace RpgSaga.v2;

public class Archer : IHero
{
    public int Health { get; set; }
    public IWeapon Weapon { get; set; }
    public string Name { get; set; }
    public string? Immunity { get; set; }
    
}