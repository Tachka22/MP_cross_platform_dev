using System;
using System.Drawing;

List<ConsoleColor> listOfColor = new List<ConsoleColor>
{
    ConsoleColor.Red,
    ConsoleColor.Green,
    ConsoleColor.Blue,
    ConsoleColor.Yellow
};
DrawNestedRectangles(10, 6, listOfColor, '#');
static void DrawNestedRectangles(int width, int height, List<ConsoleColor> colors, char symbol)
{
    int colorIndex = 0;

    while (width >= 1 && height >= 1)
    {
        Console.ForegroundColor = colors[colorIndex % colors.Count];

        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
            {
                if (i == 0 || i == height - 1 || j == 0 || j == width - 1)
                {
                    Console.Write(symbol);
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }

        width -= 2;
        height -= 2;
        colorIndex++;
    }

    Console.ForegroundColor = ConsoleColor.White;
}
//DrawRectangleInsideRectangle(10, 6, '*');


static void DrawRectangleInsideRectangle(int width, int height, char symbol)
{
    var W = 0;
    var H = 0;
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < width; j++)
        {
            if (i == H || i == height - (H+1) || j == W || j == width - (W+1))
            {
                
                Console.Write(symbol); // символ для внешнего прямоугольника

            }
            else
            {
                Console.Write(" "); // пробел для пустых областей внутри прямоугольников
            }
        }
        
        W++; H++;
        Console.WriteLine();
    }
}




//Draw(5,20, 1, 1);
void Draw(int heightOfGeom, int widthOfGeom, int W, int H)
{
    if (heightOfGeom == 0 || widthOfGeom == 0) return;
    var str = "";
    for (int height = H; height <= heightOfGeom; height++)
    {
        for (int width = W; width <= widthOfGeom; width++)
        {
            if (width > W && width < widthOfGeom && height > H && height < heightOfGeom) str += " ";
            else str += "*";
        }
        str += ("\n");
    }
    Draw(heightOfGeom - 1, widthOfGeom - 1, W + 1, H + 1);
    Console.Write(str);
}