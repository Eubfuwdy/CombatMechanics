public class CombatSystem
{
    public void StartCombat(Player player, Enemy enemy)
    {
        while (player.Health > 0 && enemy.Health > 0)
        {
            Console.WriteLine("Choose an action: 1) Attack 2) Defend 3) Parry");
            var action = Console.ReadLine();

            switch (action)
            {
                case "1":
                    player.Attack(enemy);
                    break;
                case "2":
                    player.Defend();
                    break;
                case "3":
                    player.Parry(enemy);
                    break;
                default:
                    Console.WriteLine("Invalid action");
                    break;
            }

            // Enemy's turn
            var enemyAction = new Random().Next(1, 4);
            if (enemyAction == 1)
            {
                enemy.Attack(player);
            }
            else if (enemyAction == 2)
            {
                enemy.Defend();
            }
            else
            {
                enemy.Parry(player);
            }
        }

        if (player.Health <= 0)
        {
            Console.WriteLine($"{player.Name} has been defeated.");
        }
        else
        {
            Console.WriteLine($"{enemy.Name} has been defeated.");
        }
    }
}