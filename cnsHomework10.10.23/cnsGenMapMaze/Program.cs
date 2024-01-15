using System.Runtime.CompilerServices;

namespace cnsGenMapMaze
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var g = new Game(7, 9);
            g.PrintMaze();
        }
    }
}