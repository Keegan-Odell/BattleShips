using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleshipLibrary.Models;

namespace BattleshipLibrary
{
    public class InitializeGridMethod
    {
        public static GridSpot[,] InitializeGrid()
        {
            GridSpot[,] grid = new GridSpot[5,5];

            //loop through the grid an initialize grid using A-E and 1-5
            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    grid[i, j] = i switch
                    {
                        0 => new GridSpot($"A{j + 1}", j),
                        1 => new GridSpot($"B{j + 1}", j),
                        2 => new GridSpot($"C{j + 1}", j),
                        3 => new GridSpot($"D{j + 1}", j),
                        4 => new GridSpot($"E{j + 1}", j),
                        _ => new GridSpot("FUCKING ERROR", 0),
                    };
                }
            }

            return grid;
        }
    }
}
