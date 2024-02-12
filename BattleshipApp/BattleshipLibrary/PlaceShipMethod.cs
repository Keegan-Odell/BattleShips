using BattleshipLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipLibrary
{
    public class PlaceShipMethod
    {
        public static void PlaceShips(Player player)
        {
            int counter = 0;
            List<string> shipsPlaced = [];
            Console.WriteLine($"{player.Name} please place your ships!");

            while (counter != player.ShipsLeft)
            {
                string shipToPlaceCoords = ValidateShipCoordsMethod.ValidateShipCoords(shipsPlaced);
                shipsPlaced.Add(shipToPlaceCoords);
                counter++;
            }

            Console.WriteLine("You have placed ships Where the square says 'O': ");
            ChangeShipToRepresentPlacements(shipsPlaced, player);
        }

        private static void ChangeShipToRepresentPlacements(List<string> currentlyPlacedShips, Player player)
        {
            foreach (string ship in currentlyPlacedShips)
            {
                for (int i = 0; i < player.PlayerGrid.GetLength(0); i++)
                {
                    for (int j = 0; j < player.PlayerGrid.GetLength(1); j++)
                    {
                        if (ship == player.PlayerGrid[i, j].TileName)
                        {
                            player.PlayerGrid[i, j].ShipSpot = true;
                        }
                    }
                }
            }
        }

    }
}
