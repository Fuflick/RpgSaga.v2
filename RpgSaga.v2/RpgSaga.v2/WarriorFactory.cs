namespace RpgSaga.v2;

public class WarriorFactory : IHeroFactory
{
    private static Random rnd = new Random();
    
    public IHero CreateHero(string name, int health, string immunity, IWeapon weapon)
    { 
        return new Warrior()
        {
            Name = name,
            Health = health,
            Immunity = immunity,
            Weapon = weapon,
        };
    }
}