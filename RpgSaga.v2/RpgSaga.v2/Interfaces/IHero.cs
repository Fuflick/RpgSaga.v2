namespace RpgSaga.v2;

public interface IHero
{
    int Health { get; set; }
    
   IWeapon Weapon{ get; set; }

    string Name { get; set; }
    string? Immunity { get; set; }
    
    void TakeDamage(IHero hero2)
    {
        if (Immunity == hero2.Weapon.DamageMultyplie)
        {
            Health -= hero2.Weapon.Damage;
            Console.WriteLine($"{Name} has immunity for enemy's {hero2.Weapon.DamageMultyplie}");
        }
        else
        {
            Health -= hero2.Weapon.Modifie();
            Console.WriteLine($"{Name} has no immunity for {hero2.Weapon.DamageMultyplie}");
        }

        Console.WriteLine("{0} health became {1}", Name, Health);
    }

}