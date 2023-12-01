namespace RpgSaga.v2;

public class WarriorFactory
{
    private Random _rnd = new Random();
    public IHero CreateHero(string name, int health, string immunity)
    {
        var bladeFactory = new BaldeFactory();
        var blade = bladeFactory.CreateWeapon(_rnd.Next(1, 10));
        return new Warrior()
        {
            Name = name,
            Health = health,
            Immunity = immunity,
            Weapon = blade,
        };
    }
}