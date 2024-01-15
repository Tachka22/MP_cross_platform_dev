namespace cnsDrawSnail
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DrawSpiral(10, 10, true);
        }
        static void DrawSpiral(int width, int height, bool vector)
        {
            int[,] spiral = new int[height, width];

            int value = 1;
            int left = 0;
            int right = width - 1;
            int top = 0;
            int bottom = height - 1;

            while (value  <= width * height)
            {
                if (vector)
                {
                    for (int i = left; i <= right; i++)
                    {
                        spiral[top, i] = value;
                        value++;
                    }
                    top++;

                    for (int i = top; i <= bottom; i++)
                    {
                        spiral[i, right] = value;
                        value++;
                    }
                    right--;

                    for (int i = right; i >= left; i--)
                    {
                        spiral[bottom, i] = value;
                        value++;
                    }
                    bottom--;

                    for (int i = bottom; i >= top; i--)
                    {
                        spiral[i, left] = value;
                        value++;
                    }
                    left++;
                }
                else
                {
                    for (int i = top; i <= bottom; i++)
                    {
                        spiral[i, left] = value;
                        value++;
                    }
                    left++;

                    for (int i = left; i <= right; i++)
                    {
                        spiral[bottom, i] = value;
                        value++;
                    }
                    bottom--;

                    for (int i = bottom; i >= top; i--)
                    {
                        spiral[i, right] = value;
                        value++;
                    }
                    right--;

                    for (int i = right; i >= left; i--)
                    {
                        spiral[top, i] = value;
                        value++;
                    }
                    top++;
                }
            }

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write(spiral[i, j].ToString().PadLeft(4));
                }
                Console.WriteLine();
            }
        }
    
    }
}