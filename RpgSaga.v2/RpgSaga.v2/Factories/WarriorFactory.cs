namespace RpgSaga.v2;

public class WarriorFactory : IHeroFactory
{
    public Random Rnd
    {
        get => new Random();
    }

    public IHero CreateHero(string name, int health, string immunity)
    {
        var bladeFactory = new BaldeFactory();
        var blade = bladeFactory.CreateWeapon(Rnd.Next(1, 10));
        return new Warrior()
        {
            Name = name,
            Health = health,
            Immunity = immunity,
            Weapon = blade,
        };
    }
}