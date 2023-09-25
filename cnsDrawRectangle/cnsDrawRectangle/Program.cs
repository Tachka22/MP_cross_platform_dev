using System;

namespace cnsDrawRectangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //drawRectangle();
            //drawThombus();
            //drawPyramid();
            //drawHourglass();
            bool isContinue;
            do
            {
                Console.WriteLine("Выберите фигуру:");
                Console.WriteLine("0 - Прямоугольник" + "\n" + "1 - Ромб" + "\n" + "2 - Пирамида" + "\n" + "3 - Песочные часы");
                int.TryParse(Console.ReadLine(), out var choose);
                switch (choose)
                {
                    case 0:
                        drawRectangle();
                        break;
                    case 1:
                        drawThombus();
                        break;
                    case 2:
                        drawPyramid();
                        break;
                    case 3:
                        drawHourglass();
                        break;
                }
                Console.WriteLine("Выйти из рисования фигур? [Y/N]");
                isContinue = Console.ReadLine()?.ToUpper() == "N";

            } while (isContinue);
            
        }

        static void drawRectangle()
        {
            bool isContinue;
            do
            {
                Console.WriteLine("Ширина фигуры?");
                int.TryParse(Console.ReadLine(), out var width);
                Console.WriteLine("Высота фигуры?");
                int.TryParse(Console.ReadLine(), out var height);
                Console.WriteLine("Символ рисования?");
                char.TryParse(Console.ReadLine(), out var symbol);
                Console.WriteLine("Заполнить фигуру? y/n");
                var isFill = Console.ReadLine()?.ToLower() == "y";
                Console.ForegroundColor = ConsoleColor.Yellow;
                if (isFill)
                {
                    for (int i = 0; i < height; i++)
                    {
                        Console.WriteLine(new String(symbol, width));
                        height--;
                    }
                }
                else
                {
                    string s = "";
                    s += new String(symbol, width);
                    s += "\n";
                    while (height != 2)
                    {
                        s += (symbol + new String(' ', width - 2) + symbol);
                        s += "\n";
                        height--;
                    }
                    s += new String(symbol, width);
                    Console.WriteLine(s);
                }
                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine("Продолжить? [Y/N]");
                isContinue = Console.ReadLine()?.ToUpper() == "Y";

            } while (isContinue);
        }
        static void drawThombus()
        {
            bool isContinue;
            do
            {
                Console.WriteLine("Высота фигуры?");
                int.TryParse(Console.ReadLine(), out var height);
                Console.WriteLine("Символ рисования?");
                char.TryParse(Console.ReadLine(), out var symbol);
                Console.WriteLine("Заполнить фигуру? y/n");
                var isFill = Console.ReadLine()?.ToLower() == "y";
                Console.ForegroundColor = ConsoleColor.Yellow;

                if (height % 2 == 0) height++;
          
                if (isFill)
                {
                    for (int i = 0; i < height; i++)
                    {
                        var space = Math.Abs(height / 2 - i);
                        var s = height - 2 * space;
                        Console.WriteLine(new string(' ', space) + new string(symbol, s));
                    }
                }
                else
                {
                    Console.WriteLine( new string(' ', height / 2) + symbol);
                    for (int i = 1; i < height - 1; i++)
                    {
                        var space = Math.Abs(height / 2 - i);
                        var spaceInto = height - 2 * space - 2;
                        Console.WriteLine(new string(' ', space) + symbol + new string(' ', spaceInto) + symbol);
                    }
                    Console.WriteLine( new string(' ', height / 2) + symbol);
                }

                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine("Продолжить? [Y/N]");
                isContinue = Console.ReadLine()?.ToUpper() == "Y";

            } while (isContinue);
        }
        static void drawPyramid()
        {
            bool isContinue;
            do
            {
                Console.WriteLine("Высота фигуры?");
                int.TryParse(Console.ReadLine(), out var height);
                Console.WriteLine("Символ рисования?");
                char.TryParse(Console.ReadLine(), out var symbol);
                Console.ForegroundColor = ConsoleColor.Yellow;

                for (int i = 1; i <= height; i++)
                {
                    for (int x = i; x <= height; x++)
                    {
                        Console.Write(" ");
                    }
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write(symbol + " ");
                    }
                    Console.WriteLine();

                }
                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine("Продолжить? [Y/N]");
                isContinue = Console.ReadLine()?.ToUpper() == "Y";

            } while (isContinue);
           
        }
        static void drawHourglass()
        {
            bool isContinue;
            do
            {
                Console.WriteLine("Ширина фигуры?");
                int.TryParse(Console.ReadLine(), out var width);
                Console.WriteLine("Символ рисования?");
                char.TryParse(Console.ReadLine(), out var symbol);

                Console.ForegroundColor = ConsoleColor.Yellow;

                for(int i = 1; i <= width; i++) {
                    Console.WriteLine();
                    for (int j = 1; j <= width; j++)
                    {
                        if (j >= i && j <= width - i + 1 || j <= i && j >= width - i + 1)
                        {
                            Console.Write(symbol);
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                }

                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine("Продолжить? [Y/N]");
                isContinue = Console.ReadLine()?.ToUpper() == "Y";

            } while (isContinue);
        }

    }
    
}