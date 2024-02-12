using BattleshipLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipLibrary
{
    public class ConsoleDrawGridMethod
    {
        public static void ConsoleDrawGrid(Player player)
        {
            for (int i = 0; i < player.PlayerGrid.GetLength(0); i++)
            {
                for (int j = 0; j < player.PlayerGrid.GetLength(1); j++)
                {
                    Console.Write(DrawGridMethod.DrawGrid(player.PlayerGrid[i, j]));
                }
                Console.WriteLine();
            }
        }

        public static void ConsoleDrawGridShown(Player player)
        {
            for (int i = 0; i < player.PlayerGrid.GetLength(0); i++)
            {
                for (int j = 0; j < player.PlayerGrid.GetLength(1); j++)
                {
                    Console.Write(DrawGridMethod.DrawGridShown(player.PlayerGrid[i, j]));
                }
                Console.WriteLine();
            }
        }
    }
}
