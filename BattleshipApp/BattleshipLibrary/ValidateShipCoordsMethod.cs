using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipLibrary
{
    public class ValidateShipCoordsMethod
    {
        public static string ValidateShipCoords(List<string> currentlyPlacedShips)
        {
            char[] legalChars = ['A', 'B', 'C', 'D', 'E'];
            char[] legalNumChars = ['1', '2', '3', '4', '5'];

            while (true)
            {
                Console.WriteLine("You can pick a letter A-E and a number 1-5, just don't repeat yourself! ");
                string? stringToCheck = Console.ReadLine();

                if (
                    !string.IsNullOrWhiteSpace(stringToCheck)
                    && stringToCheck.Length == 2
                    && legalChars.Contains(char.ToUpper(stringToCheck[0]))
                    && legalNumChars.Contains(stringToCheck[1])
                    && !currentlyPlacedShips.Contains($"{char.ToUpper(stringToCheck[0])}{stringToCheck[1]}")
                )
                {
                    string stringToReturn = $"{char.ToUpper(stringToCheck[0])}{stringToCheck[1]}";
                    return stringToReturn;
                }

                Console.WriteLine("Incorrect coordinate input!");
            }
        }
    }
}
