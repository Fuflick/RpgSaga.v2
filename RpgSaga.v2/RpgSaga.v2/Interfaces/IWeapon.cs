namespace RpgSaga.v2;

public interface IWeapon
{
    string Type { get; }

    int Damage { get; }
    
    public string DamageMultyplie { get; set; }

    public int Modifie();

}