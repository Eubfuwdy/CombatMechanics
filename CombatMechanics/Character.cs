public abstract class Character
{
    public string Name { get; set; }
    public int Health { get; set; }
    public int Stamina { get; set; }

    public Character(string name, int health, int stamina)
    {
        Name = name;
        Health = health;
        Stamina = stamina;
    }

    public abstract void Attack(Character target);
    public abstract void Defend();
    public abstract void Parry(Character attacker);
}
