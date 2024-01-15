using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cnsGenMapMaze
{
    internal class Game
    {
        private int height;
        private int width;
        private int[] start;
        private int[] end;
        private char[][] maze;

        public Game(int height, int width, int[] start = null, int[] end = null)
        {
            this.height = height;
            this.width = width;
            this.start = start != null ? start : new int[] { 0, new Random().Next(1, width - 2) };
            this.end = end != null ? end : new int[] { height - 1, new Random().Next(1, width - 2) };
        }

        public void PrintMaze()
        {

        }
    }
}
