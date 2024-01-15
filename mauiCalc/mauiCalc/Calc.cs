namespace mauiCalc
{
    internal class Calc
    {
        private int numCur;
        private Oper oper;
        private int numLast;

        public event EventHandler ChangedDisplay;

        private enum Oper { Div, Mul, Sub, Sum}
        public string DisplayText
        {
            get
            {
                return numCur.ToString();
            }
        }
        internal void CE()
        {
            throw new NotImplementedException();
        }

        internal void PressNum(int v)
        {
            numCur = numCur * 10 + v;
            ChangedDisplay?.Invoke(this, EventArgs.Empty);  
        }

        internal void Pow()
        {
            numCur = (int)Math.Pow(numCur, 2);
            ChangedDisplay?.Invoke(this, EventArgs.Empty);
        }

        internal void PressDiv()
        {
            throw new NotImplementedException();
        }

        internal void PressMul()
        {
            throw new NotImplementedException();
        }

        internal void PressSub()
        {
            throw new NotImplementedException();
        }

        internal void PressSum()
        {
            oper = Oper.Sum;
            numLast = numCur;
            numCur = 0;
        }

        internal void PressEquals()
        {
           switch(oper)
            {
                case Oper.Div:
                    break;
                case Oper.Mul:
                    break;
                case Oper.Sub:
                    break;
                case Oper.Sum: 
                    numCur = numLast + numCur;
                    break;
            }
        }
    }
}