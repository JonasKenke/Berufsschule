namespace Random;

class Program
{
    private static readonly List<Character> Characters = new List<Character>();

    public static void Main(string[] args)
    {
        initialize();
        printCharacters();
    }

    private static void initialize()
    {
        System.Random random = new System.Random();
        int characterCount = random.Next(1, 10);

        for (int i = 0; i < characterCount; i++)
        {
            switch (random.Next(0, 3))
            {
                case 0:
                    Characters.Add(new Knight());
                    break;
                case 1:
                    Characters.Add(new Barbarian());
                    break;
                case 2:
                    Characters.Add(new Witch());
                    break;
            }
        }
    }

    private static void printCharacters()
    {
        foreach (Character character in Characters)
        {
            character.show();
        }
    }
}

internal abstract class Character
{
    public abstract void show();
}

internal class Knight : Character
{
    public override void show()
    {
        Console.WriteLine("Knight");
    }
}

internal class Barbarian : Character
{
    public override void show()
    {
        Console.WriteLine("Barbarian");
    }
}

internal class Witch : Character
{
    public override void show()
    {
        Console.WriteLine("Witch");
    }
}
