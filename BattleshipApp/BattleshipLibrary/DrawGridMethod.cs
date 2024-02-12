using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleshipLibrary.Models;

namespace BattleshipLibrary
{
    public class DrawGridMethod
    {
        public static string DrawGrid(GridSpot gridSpot)
        {
            string gridLine;

            if (!gridSpot.ShipSpot && !gridSpot.HitSpot)
            {
                gridLine = gridSpot.TileNumber switch
                {
                    0 => $"|{gridSpot.TileName}",
                    1 => $"|{gridSpot.TileName}|",
                    2 => $"{gridSpot.TileName}|",
                    3 => $"{gridSpot.TileName}|",
                    4 => $"{gridSpot.TileName}|",
                    _ => "FUCKING ERROR"
                };
            }
            else if (gridSpot.ShipSpot && !gridSpot.HitSpot)
            {
                gridLine = gridSpot.TileNumber switch
                {
                    0 => "| O",
                    1 => "| O|",
                    2 => " O|",
                    3 => " O|",
                    4 => " O|",
                    _ => "FUCKING ERROR"
                };
            }
            else if (gridSpot.ShipSpot && gridSpot.HitSpot)
            {
                gridLine = gridSpot.TileNumber switch
                {
                    0 => "| X",
                    1 => "| X|",
                    2 => " X|",
                    3 => " X|",
                    4 => " X|",
                    _ => "FUCKING ERROR"
                };
            }
            else
            {
                gridLine = gridSpot.TileNumber switch
                {
                    0 => "| /",
                    1 => "| /|",
                    2 => " /|",
                    3 => " /|",
                    4 => " /|",
                    _ => "FUCKING ERROR"
                };
            }

            return gridLine;
        }

        public static string DrawGridShown(GridSpot gridSpot)
        {
            string gridLine;

            if (!gridSpot.HitSpot)
            {
                gridLine = gridSpot.TileNumber switch
                {
                    0 => $"|{gridSpot.TileName}",
                    1 => $"|{gridSpot.TileName}|",
                    2 => $"{gridSpot.TileName}|",
                    3 => $"{gridSpot.TileName}|",
                    4 => $"{gridSpot.TileName}|",
                    _ => "FUCKING ERROR"
                };
            }
            else if (gridSpot.ShipSpot && gridSpot.HitSpot)
            {
                gridLine = gridSpot.TileNumber switch
                {
                    0 => "| X",
                    1 => "| X|",
                    2 => " X|",
                    3 => " X|",
                    4 => " X|",
                    _ => "FUCKING ERROR"
                };
            }
            else
            {
                gridLine = gridSpot.TileNumber switch
                {
                    0 => "| /",
                    1 => "| /|",
                    2 => " /|",
                    3 => " /|",
                    4 => " /|",
                    _ => "FUCKING ERROR"
                };
            }

            return gridLine;
        }
    }

}
