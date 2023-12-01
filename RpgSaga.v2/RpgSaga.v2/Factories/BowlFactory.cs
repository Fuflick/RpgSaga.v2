namespace RpgSaga.v2;

public class BowlFactory
{
    public IWeapon CreateWeapon(int damage)
    {
        return new Bowl()
        {
            Type = "Bowl",
            Damage = damage,
            DamageMultyplie = "poison"
        };
    }
}