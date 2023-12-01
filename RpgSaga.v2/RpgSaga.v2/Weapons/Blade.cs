namespace RpgSaga.v2;

public class Blade : IWeapon
{
    public string Type { get; set; }

    public int Damage { get; set; }
    public string DamageMultyplie { get; set; }

    public int Modifie()
    {
        return Damage += 5;
    }
}