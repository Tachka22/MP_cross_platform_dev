
namespace wfGameTrainerAccount
{
    public class Case
    {
        public int xValue1 {  get;  set; }
        public int xValue2 { get; set;}
        public double xResult { get; set;}
        public char Symbol { get; set; } 
        public double xResultNew { get; set; }

        public Case()
        {
        }

        public Case(int xValue1, int xValue2, double xResult, char symbol, double xResultNew)
        {
            this.xValue1 = xValue1;
            this.xValue2 = xValue2;
            this.xResult = xResult;
            Symbol = symbol;
            this.xResultNew = xResultNew;
        }
    }
}
