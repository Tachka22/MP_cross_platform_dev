namespace cnsGenMapSapper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            //GenerateMap(9, 9, 6, new List<(int, int)> { (2, 2), (4, 4), (6, 6) });
            char[][] map3 = GenerateMap(8, 8, 5, new List<(int, int)> { (2, 2), (4, 4), (6, 6) });
            
        }

        private static char[][] GenerateMap(int height = 9, int width = 9, int countMines = 10, List<(int, int)> mineCoordinates = null, (int, int)? firstMove = null)
        {

        }
    }
}