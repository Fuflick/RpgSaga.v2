namespace RpgSaga.v2;

public class MagicFactory
{
    public Random Rnd { get; }
    
    public IWeapon CreateWeapon(IWeapon weapon, string disable)
    {
        return new Magic()
        {
            Disable = disable,
            Damage = weapon.Damage,
            
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