namespace RpgSaga.v2;

public interface IHeroFactory
{
    IHero CreateHero(string name, int health, string immunity, IWeapon weapon);
}