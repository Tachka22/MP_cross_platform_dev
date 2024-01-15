using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaExam2._0
{
    public class Game
    {
        public int Rows { get; set; } = 5;
        public int Columns { get; set; } = 5;

        public int Score { get; set; } = 1;
        public int MaxScore { get; set; } = 10;

        public int MaxLevel { get; set; } = 10;
        public int Level { get; set; } = 1;

        public bool ActiveGame { get; set; } = true;

        public bool CheckActiveGame()
        {
            if (Level >= MaxLevel) return false;
            return true;
        }
    }

}
