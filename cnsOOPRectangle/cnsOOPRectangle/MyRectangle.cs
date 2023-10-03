namespace cnsOOPRectangle
{
    internal class MyRectangle
    {
        private int width;
        private int height;
        
        public MyRectangle(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public MyRectangle()
        {
            this.width = 0;
            this.height = 0;
        }
        public int GetArea()
        {
            return width * height;
        }
    }
}