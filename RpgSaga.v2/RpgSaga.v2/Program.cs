namespace RpgSaga.v2;

public class Program
{
    private static readonly List<string> Immunities = new List<string>()
    {
        "Fire",
        "Cold",
        "Poison",
        "No immunity"
    };
    
    private static readonly List<string> Names = new List<string>()
    {
        "Ares",
        "Thor",
        "Xena",
        "Cleopatra",
        "Gideon",
        "Valeria",
        "Conan",
        "Bellina",
        "Ragnar",
        "Artemis"
    };

    private static Random _rnd = new Random();
    
    static void Main()
    {
        var bladeFactory = new BaldeFactory();
        var blade = bladeFactory.CreateWeapon(_rnd.Next(1, 11));
        var warriorFactory = new WarriorFactory();
        var warrior = warriorFactory.CreateHero(Names[_rnd.Next(0, Names.Count)], _rnd.Next(10, 45), Immunities[_rnd.Next(0, Immunities.Count)], blade );
        Console.WriteLine($"Name = {warrior.Name}, health = {warrior.Health}, immunity = {warrior.Immunity}, weapon is {warrior.Weapon.Type} and in's damage is {warrior.Weapon.Damage}");
    }
}