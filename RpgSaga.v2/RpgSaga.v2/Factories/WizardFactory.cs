namespace RpgSaga.v2;

public class WizardFactory
{
    private Random _rnd = new Random(); 

    public IHero CreateHero(string name, int health, string immunity)
    {
        var magicFactory = new MagicFactory();
        var magic = magicFactory.CreateWeapon(_rnd.Next(15, 51));
        return new Wizard()
        {
            Name = name,
            Health = health,
            Immunity = immunity,
            Weapon = magic,
        };
    }
}