namespace RpgSaga.v2;

public class ArcherFactory : IHeroFactory 
{
    public Random Rnd { get => new Random(); }
    
    public IHero CreateHero(string name, int health, string immunity)
    {
        var bowlFactory = new BowlFactory();
        var bowl = bowlFactory.CreateWeapon(Rnd.Next(10, 25));
        return new Archer()
        {
            Name = name,
            Health = health,
            Immunity = immunity,
            Weapon = bowl,
        };
    }
}