using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleshipLibrary.Models;

namespace BattleshipLibrary
{
    public class ShootingMethod
    {
        public static void PlayerShoot(Player player1, Player player2, List<string> shotsFiredList)
        {
            //Console chatter to instruct to take a shot and then validates a correct shot
            Console.WriteLine($"{player1.Name} Please take your shot. {player2.Name} has {player2.ShipsLeft} remaining");
            string placedShot = ValidateShipCoordsMethod.ValidateShipCoords(shotsFiredList);
            shotsFiredList.Add(placedShot);

            //this is the logic for changing the board and displaying a hit or miss
            for (int i = 0; i < player2.PlayerGrid.GetLength(0); i++)
            {
                for (int j = 0; j < player2.PlayerGrid.GetLength(1); j++)
                {
                    if (player2.PlayerGrid[i, j].TileName != placedShot)
                    {
                        continue;
                    }

                    if (!player2.PlayerGrid[i,j].ShipSpot)
                    {
                        player1.ShotsFired++;
                        player2.PlayerGrid[i, j].HitSpot = true;
                        Console.WriteLine("Sorry you completely missed!");
                        break;
                    }

                    player1.ShotsFired++;
                    player2.ShipsLeft--;
                    player2.PlayerGrid[i, j].HitSpot = true;
                    Console.WriteLine("YOU HIT A BATTLESHIP!");
                }
            }
        }
    }
}
