namespace cnsOOPRectangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyRectangle x = new();
            Console.WriteLine(x.GetArea());

            MyRectangle y = new(2, 5);
            Console.WriteLine(y.GetArea());
        }
    }
}