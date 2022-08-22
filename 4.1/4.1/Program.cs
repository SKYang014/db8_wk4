
Warrior Patrick = new Warrior("Patrick Star", 8, 1, "rock");
Warrior Larry = new Warrior("Larry the Lobster", 15, 5, "claws");
Warrior Sandy = new Warrior("Sandy Cheeks", 15, 15, "KA-RAH-TAY");

Wizard SpongeBob = new Wizard("SpongeBob Squarepants", 1, 3, 5, 2);
Wizard Krabs = new Wizard("Mr.Krabs", 5, 5, 10, 1);

List<GameCharacter> party = new List<GameCharacter>();

party.Add(Patrick);
party.Add(Larry);
party.Add(Sandy);
party.Add(SpongeBob);
party.Add(Krabs);

foreach (GameCharacter member in party)
{
    member.Play();
}

class GameCharacter
{
    public string Name;
    public int Strength;
    public int Intelligence;

    public GameCharacter( string aName, int aStrength, int aIntelligence)
    {
        Name = aName;
        Strength = aStrength;
        Intelligence = aIntelligence;
    }

    public virtual void Play()
    {
        Console.WriteLine($"{Name} has {Strength} strength and {Intelligence} intelligence.");
    }
}

class Warrior : GameCharacter
{
    public string WeaponType;

    public Warrior(string aName, int aStrength, int aIntelligence, string aWeaponType)
        : base(aName, aStrength, aIntelligence)
    {
        WeaponType = aWeaponType;
    }

    public override void Play()
    {
        Console.WriteLine($"Warrior {Name} uses a {WeaponType} and has {Strength} strength and {Intelligence} intelligence.");  
    }
}

class MagicUser : GameCharacter
{
    public int magicalEnergy;

    public MagicUser(string aName, int aStrength, int aIntelligence, int aMagicalEnergy)
        : base(aName, aStrength, aIntelligence)
    {
        magicalEnergy = aMagicalEnergy;
    }

    public override void Play()
    {
        Console.WriteLine($"Magic user {Name} has {Strength} strength and {Intelligence} intelligence and {magicalEnergy} magical energy");
    }
}

class Wizard : MagicUser
{
    public int SpellNumber;

    public Wizard(string aName, int aStrength, int aIntelligence, int aMagicalEnergy, int aSpellNumber)
        : base(aName, aStrength, aIntelligence, aMagicalEnergy)
    {
        SpellNumber = aSpellNumber;
    }

    public override void Play()
    {
        Console.WriteLine($"Wiazrd {Name} has {Strength} strength and {Intelligence} intelligence and {SpellNumber} magical energy with {SpellNumber} spells.");
    }
}