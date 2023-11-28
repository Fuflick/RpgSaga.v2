using System.Threading.Channels;

namespace RpgSaga.v2;

public class Program
{
    private readonly List<string> _immunities = new List<string>()
    {
        "Fire",
        "Cold",
        "Poison"
    };
    
    private readonly List<string> _names = new List<string>()
    {
        "Ares",
        "Thor",
        "Xena",
        "Cleopatra",
        "Gideon",
        "Valeria",
        "Conan",
        "Bellona",
        "Ragnar",
        "Artemis"
    };

    private static Random rnd = new Random();
    
    static void Main()
    {
        Console.WriteLine("hui");
    }
}