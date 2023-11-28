namespace RpgSaga.v2;

public class ArcherFactory : IHeroFactory 
{
    public IHero CreateHero(string name, int health, string immunity, IWeapon weapon)
    {
        return new Archer()
        {
            Name = name,
            Health = health,
            Immunity = immunity,
            Weapon = weapon,
        };
    }
}