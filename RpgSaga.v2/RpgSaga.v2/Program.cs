namespace RpgSaga.v2;

public class Program
{
    private static readonly List<string> Immunities = new List<string>()
    {
        "nausea",
        "bleeding",
        "poison",
        "no immunity"
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
        while (true)
        {
            var rnd = new Random();
            var warriorFactory = new WarriorFactory();
            var warrior = warriorFactory.CreateHero(Names[_rnd.Next(0, Names.Count)], _rnd.Next(25, 50), Immunities[_rnd.Next(0, Immunities.Count)]);
            Console.WriteLine($"Name = {warrior.Name}, health = {warrior.Health}, immunity = {warrior.Immunity}, weapon is {warrior.Weapon.Type} and in's damage is {warrior.Weapon.Damage}");
        
            var archerFactory = new ArcherFactory();
            var archer = archerFactory.CreateHero(Names[_rnd.Next(0, Names.Count)], _rnd.Next(10, 21), Immunities[_rnd.Next(0, Immunities.Count)]);
            Console.WriteLine($"Name = {archer.Name}, health = {archer.Health}, immunity = {archer.Immunity}, weapon is {archer.Weapon.Type} and in's damage is {archer.Weapon.Damage}");

            var wizrdFactory = new WizardFactory();
            var wizard = warriorFactory.CreateHero(Names[_rnd.Next(0, Names.Count)], _rnd.Next(10, 15), Immunities[_rnd.Next(0, Immunities.Count)]);

            var list = new List<IHero>()
            {
                warrior, wizard, archer,
            };

            var party = new List<IHero>();
            party.Add(list[rnd.Next(0, list.Count)]);
            party.Add(list[rnd.Next(0, list.Count)]);

            if (party[0] != party[1])
            {
                while (party[0].Health > 0 && party[1].Health > 0)
                {
                    party[0].TakeDamage(party[1]);
                    if (party[0].Health > 0)
                    {
                        party[1].TakeDamage(party[0]);
                    }
                    
                    Thread.Sleep(3000);
                }

                Console.WriteLine("Fight end \n");
            }
        }
        
        
        
    }
}