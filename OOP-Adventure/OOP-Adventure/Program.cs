using OOPAdventure;

var language = new English();

Console.WriteLine(language.ChooseYourName);

var name = Console.ReadLine();

if (name == string.Empty)
    name = "Player";

var player = new Player(name);

Console.WriteLine("Hello {0}, to your OOP Adventure!", player.Name);