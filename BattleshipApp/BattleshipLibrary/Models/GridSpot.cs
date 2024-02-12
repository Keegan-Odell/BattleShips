using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipLibrary.Models
{
    public class GridSpot(string tileName, int tileNumber)
    {
        public string TileName { get; set; } = tileName;
        public bool HitSpot { get; set; } = false;
        public bool ShipSpot { get; set; } = false;
        public int TileNumber { get; } = tileNumber;
    }
}
