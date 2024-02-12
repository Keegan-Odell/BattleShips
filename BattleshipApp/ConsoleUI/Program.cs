using BattleshipLibrary;
using BattleshipLibrary.Models;

//Ask for player 1 & player 2
string playerName1 = ConsoleChatter.ValidateName();
Console.Clear();
string playerName2 = ConsoleChatter.ValidateName();
Console.Clear();

//Selection of new players
Player player1 = new(playerName1);
Player player2 = new(playerName2);

//Opening shot of the grid to show the player what is going on
ConsoleChatter.OpeningGridDialogue(player1);
ConsoleChatter.OpeningGridDialogue(player2);

//Place ships for player1 and show the player where you placed them.
ConsoleChatter.PlaceAndDrawShips(player1);

//clear console
Console.Clear();

//place ships for player2 and show the player where you placed them
ConsoleChatter.PlaceAndDrawShips(player2);

//clear console
Console.Clear();

List<string> player1Shots = [];
List<string> player2Shots = [];

//gameplay loop
while (true)
{
    ConsoleDrawGridMethod.ConsoleDrawGridShown(player2);
    ShootingMethod.PlayerShoot(player1, player2, player1Shots);
    ConsoleDrawGridMethod.ConsoleDrawGridShown(player2);
    Console.WriteLine("----------------------------------------------------------");
    ConsoleDrawGridMethod.ConsoleDrawGridShown(player1);
    ShootingMethod.PlayerShoot(player2, player1, player2Shots);
    ConsoleDrawGridMethod.ConsoleDrawGridShown(player1);
    Console.WriteLine("-----------------------------------------------------------");
    Console.ReadLine();
    Console.Clear();

    //end game logic
    if (player1.ShipsLeft == 0)
    {
        Console.WriteLine($"{player2.Name} WINNNNSSS");
        break;
    }

    if (player2.ShipsLeft == 0)
    {
        Console.WriteLine($"{player1.Name} WINNNNSSS");
        break;
    }
}

Console.WriteLine("Thanks for playing my battleship game!");

internal class ConsoleChatter
{
    internal static void OpeningGridDialogue(Player player)
    {
        Console.WriteLine($"{player.Name} Here is your grid! the coordinates represent places to attack!");
        ConsoleDrawGridMethod.ConsoleDrawGrid(player);
        Console.WriteLine("______________________________");
        Console.WriteLine("Press enter to proceed");
        Console.ReadLine();
        Console.Clear();
    }

    internal static void PlaceAndDrawShips(Player player)
    {
        PlaceShipMethod.PlaceShips(player);
        ConsoleDrawGridMethod.ConsoleDrawGrid(player);
        Console.WriteLine("Remember where your ships are, you wont see them again. Press enter to continue");
        Console.ReadLine();
    }

    internal static string ValidateName()
    {
        string? playerName;
        do
        {
            Console.Write("Whats your name?: ");
            playerName = Console.ReadLine();

        } while (string.IsNullOrWhiteSpace(playerName));

        return playerName;
    }
}