namespace RpgSaga.v2;

public class MagicFactory
{
    public Random Rnd { get; }
    
    public IWeapon CreateWeapon(IWeapon weapon)
    {
        return new Magic()
        {
            Damage = weapon.Damage,
            DamageMultyplie = "nausea"
        };
    }
    
    public IWeapon CreateWeapon(int damage)
    {
        return new Magic()
        {
            Type = "Magic",
            Damage = damage,
        };
    }
}