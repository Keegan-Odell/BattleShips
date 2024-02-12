using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipLibrary.Models
{
    public class Player(string name)
    {
        public string Name { get; } = name;
        public int ShipsLeft { get; set; } = 5;
        public int ShotsFired { get; set; } = 0;
        public GridSpot[,] PlayerGrid { get; } = InitializeGridMethod.InitializeGrid();
    }
}
