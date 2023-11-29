namespace RpgSaga.v2;

public interface IWeaponFactory
{
    // damage will be specified in program class, before hero's creation
    IWeapon CreateWeapon(int damage);  
}