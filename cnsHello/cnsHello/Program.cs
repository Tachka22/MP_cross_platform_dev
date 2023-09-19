using System.Xml;

namespace cnsHello
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isContinue;
            do
            {
                Console.WriteLine("Длина?");
                int.TryParse(Console.ReadLine(), out int width);

                for (int i = 0; i < width; i++)
                {
                    Console.BackgroundColor = ConsoleColor.Magenta;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("-");
                }
                Console.BackgroundColor = ConsoleColor.Magenta;
                Console.ForegroundColor = ConsoleColor.Red;
                //Console.Write(new String('#', width));
                //Console.BackgroundColor = ConsoleColor.Black;
                //Console.WriteLine();

               

                Console.WriteLine("Продолжить? [Y/N]");
                isContinue = Console.ReadLine()?.ToUpper() == "Y";

            } while (isContinue);
        }
    }
}