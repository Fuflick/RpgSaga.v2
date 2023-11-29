namespace RpgSaga.v2;

public class WizardFactory : IHeroFactory
{
    public Random Rnd
    {
        get => new Random();
    }

    public IHero CreateHero(string name, int health, string immunity)
    {
        var magicFactory = new MagicFactory();
        var magic = magicFactory.CreateWeapon(Rnd.Next(15, 51));
        return new Wizard()
        {
            Name = name,
            Health = health,
            Immunity = immunity,
            Weapon = magic,
        };
    }
}