using System;

class Hero { private string name; private string type; private string abilityName; private int attack; private int defense;

public Hero(string heroName, string heroType, string heroAbility) {
name = heroName;
type = heroType;
abilityName = heroAbility;
if (type == "Defender") {
attack = 10;
defense = 25;
}
else if (type == "Duelist") {
attack = 20;
defense = 20;
}
else if (type == "Marksman") {
attack = 25;
defense = 15;
}
}

public void showStats() {
Console.WriteLine("Hero Name: " + name);
Console.WriteLine("Hero Type: " + type);
Console.WriteLine("Attack: " + attack);
Console.WriteLine("Defense: " + defense);
}

public void castAbility() {
Console.WriteLine(name + " used their ability " + abilityName + " dealing damage equal to their attack: " + attack);
}

}

class Program { static void Main() { Console.WriteLine("Enter the Hero's name: "); string heroName = Console.ReadLine(); Console.WriteLine("Enter the Hero's type (Defender, Duelist, Marksman): "); string heroType = Console.ReadLine(); Console.WriteLine("Enter the Hero's ability name: "); string heroAbility = Console.ReadLine();

Hero playerHero = new Hero(heroName, heroType, heroAbility);

playerHero.showStats();
playerHero.castAbility();
}
}