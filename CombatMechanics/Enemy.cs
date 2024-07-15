public class Enemy : Character
{
    public Enemy(string name, int health, int stamina) : base(name, health, stamina) { }

    public override void Attack(Character target)
    {
        Console.WriteLine($"{Name} is attacking {target.Name}");
        target.Defend();
    }

    public override void Defend()
    {
        Console.WriteLine($"{Name} is defending");
    }

    public override void Parry(Character attacker)
    {
        Console.WriteLine($"{Name} parried the attack from {attacker.Name}");
    }
}