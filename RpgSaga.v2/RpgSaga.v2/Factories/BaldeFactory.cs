namespace RpgSaga.v2;

public class BaldeFactory : IWeaponFactory
{
    public IWeapon CreateWeapon(int damage)
    {
        return new Blade()
        {
            Type = "Blade",
            Damage = damage,
        };
    }
}