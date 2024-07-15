class Program
{
    static void Main(string[] args)
    {
        var player = new Player("Sekiro", 100, 50);
        var enemy = new Enemy("Samurai", 80, 30);

        var combatSystem = new CombatSystem();
        combatSystem.StartCombat(player, enemy);
    }
}