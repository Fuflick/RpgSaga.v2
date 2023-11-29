namespace RpgSaga.v2;

public interface IHeroFactory
{
    Random Rnd { get; }
    IHero CreateHero(string name, int health, string immunity);
}

