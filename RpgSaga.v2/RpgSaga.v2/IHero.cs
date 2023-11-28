namespace RpgSaga.v2;

public interface IHero
{
    int Health { get; set; }
    
   IWeapon Weapon{ get; set; }

    string Name { get; set; }
    string? Immunity { get; set; }

    bool HasImmunity(string immunityType)
    {
        return Immunity!.Contains(immunityType);
    }

    void TakeDamage(IHero hero2)
    {
        Health -= Weapon.Damage;
    }
    
}