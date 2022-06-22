// This is challenge work for the "C# Players Guide"
// This is for the Level 29  "War Preparations" Challenge
// This is a challenge to use a record

//Create Sword using record
BuildSword BasicSword = new BuildSword(Gemstones.Empty, Material.Iron, 6, .5f);

//Build two using "With" expressions
BuildSword MidRangeSword = BasicSword with { GemstoneChoice = Gemstones.Emerald, MaterialChoice = Material.Steel };
BuildSword HighendSword = BasicSword with { GemstoneChoice = Gemstones.Bitstone, MaterialChoice = Material.Binarium, SwordLength = 8 };

Console.WriteLine($"This is the Basic Sword that was created: {BasicSword}\n");
Console.WriteLine($"This is the Mid-Range Sword that was created: {MidRangeSword}\n");
Console.WriteLine($"This is the High-End Sword that was created: {HighendSword} \n");
Console.WriteLine("Press any key to end the program");
Console.ReadKey();


//Sword Record
public record BuildSword(Gemstones GemstoneChoice, Material MaterialChoice, float SwordLength, float SwordCrossguard);

//Enums
public enum Gemstones { Emerald, Amber, Sapphire, Diamond, Bitstone, Empty }
public enum Material { Wood, Bronze, Iron, Steel, Binarium, }