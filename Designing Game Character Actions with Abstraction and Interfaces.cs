using System;

public abstract class GameCharacter
{
    public string Name { get; set; }
    public int Health { get; set; }

    protected GameCharacter(string name, int health)
    {
        Name = name;
        Health = health;
    }

    public abstract void DisplayStatus();
}

public interface IActions
{
    void Attack(GameCharacter target);
    void Defend();
    void SpecialAttack(GameCharacter target);
}

public class Warrior : GameCharacter, IActions
{
    public Warrior(string name, int health) : base(name, health) { }

    public override void DisplayStatus()
    {
        Console.WriteLine($"{Name} (Warrior) - Health: {Health}");
    }

    public void Attack(GameCharacter target)
    {
        int damage = 345;
        Console.WriteLine($"{Name} attacks {target.Name} for {damage} damage!");
        target.Health -= damage;
        if (target.Health < 0) target.Health = 0;
    }

    public void Defend()
    {
        Console.WriteLine($"{Name} defends and reduces incoming damage!");
    }

    public void SpecialAttack(GameCharacter target)
    {
        int damage = 250;
        Console.WriteLine($"{Name} performs a special attack on {target.Name} for {damage} damage!");
        target.Health -= damage;
        if (target.Health < 0) target.Health = 0;
    }
}

public class Mage : GameCharacter, IActions
{
    public Mage(string name, int health) : base(name, health) { }

    public override void DisplayStatus()
    {
        Console.WriteLine($"{Name} (Mage) - Health: {Health}");
    }

    public void Attack(GameCharacter target)
    {
        int damage = 250;
        Console.WriteLine($"{Name} casts a special Big Magical YAAHHHHHHHH attack on {target.Name} for {damage} damage!");
        target.Health -= damage;
        if (target.Health < 0) target.Health = 0;
    }

    public void Defend()
    {
        Console.WriteLine($"{Name} uses a magical Big Daddy shield to defend!");
    }

    public void SpecialAttack(GameCharacter target)
    {
        int damage = 365;
        Console.WriteLine($"{Name} casts a powerful Ultra Booogshh force on {target.Name} for {damage} damage!");
        target.Health -= damage;
        if (target.Health < 0) target.Health = 0;
    }
}

public class Program
{
    public static void Main()
    {
        Warrior warrior = new Warrior("Ohh yeaahh", 1825);
        Mage mage = new Mage("Ohhh yess yess ", 1700);

        warrior.DisplayStatus();
        mage.DisplayStatus();

        warrior.Attack(mage);
        mage.DisplayStatus();  
        mage.Defend();
        mage.SpecialAttack(warrior);
        warrior.DisplayStatus();  

        warrior.DisplayStatus();
        mage.DisplayStatus();

        Battle(warrior, mage);
    }

    public static void Battle(IActions character1, IActions character2)
    {
        while (character1 is GameCharacter c1 && character2 is GameCharacter c2 && c1.Health > 0 && c2.Health > 0)
        {
            character1.Attack(c2);
            c2.DisplayStatus();  
            if (c2.Health <= 0)
            {
                Console.WriteLine($"{c2.Name} Defeated {c1.Name} and said: AHUUU! YAHH YAHH!");
                break;
            }

            character2.Attack(c1);
            c1.DisplayStatus();  
            if (c1.Health <= 0)
            {
                Console.WriteLine($"{c1.Name} Defeated {c2.Name} and said: OHHH YEAAAAHHHHHH!");
                break;
            }
        }
    }
}
