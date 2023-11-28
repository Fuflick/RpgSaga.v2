namespace RpgSaga.v2;

public class BowlFactory : IWeaponFactory
{
    public IWeapon CreateWeapon(int damage)
    {
        return new Bowl()
        {
            Type = "Bowl",
            Damage = damage,
        };
    }
}