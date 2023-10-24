namespace wfGameTrainerAccount
{
    
    public class Game
    {
        private Random rnd = new();
        private Case cse = new();
        private Stack<Case> cases = new Stack<Case>();

        public int Level { get;  set; }
        public int CountCorrect { get; private set; }
        public int CountWrong { get; private set; }
        public string CodeText { get; private set; }
        public bool AnswerCorrect { get; private set; }
        public event EventHandler Change;

        private enum Operation
        {
            Add,
            Subtract,
            Multiply,
            Divide
        }
        //Выбор оператора.
        private (double, char) DoOperation(double x, double y, Operation op)
        {
            double result = op switch
            {
                Operation.Add => x + y,
                Operation.Subtract => x - y,
                Operation.Multiply => x * y,
                Operation.Divide => x / y
            };
            char symbol = op switch
            {
                Operation.Add => '+',
                Operation.Subtract => '-',
                Operation.Multiply => '*',
                Operation.Divide => '/'
            };
            return (result, symbol);
        }
        //Сбросить ответы.
        public void DoReset()
        {
            
            CountCorrect = 0;
            CountWrong = 0;
            DoContinue();       
        }
        //Продолжить.
        private void DoContinue()
        {
            cse.Symbol = '+';
            switch (Level)
            {
                case 0:
                    cse.xValue1 = rnd.Next(20);
                    cse.xValue2 = rnd.Next(20);
                    (cse.xResult, cse.Symbol) = DoOperation(cse.xValue1, cse.xValue2, (Operation)0);
                    break;
                case 1:
                    cse.xValue1 = rnd.Next(40);
                    cse.xValue2 = rnd.Next(40);
                    (cse.xResult, cse.Symbol) = DoOperation(cse.xValue1, cse.xValue2, (Operation)rnd.Next(0,2));
                    break;
                case 2:
                    cse.xValue1 = rnd.Next(40,80);
                    cse.xValue2 = rnd.Next(40,80);
                    (cse.xResult, cse.Symbol) = DoOperation(cse.xValue1, cse.xValue2, (Operation)rnd.Next(0, 4));
                    break;
                default:
                    cse.xValue1 = rnd.Next(20);
                    cse.xValue2 = rnd.Next(20);
                    (cse.xResult, cse.Symbol) = DoOperation(cse.xValue1, cse.xValue2, (Operation)0);
                    break;
            }
            
            

            cse.xResultNew = RandomWrong(cse.xResult);

            CodeText = $"{cse.xValue1} {cse.Symbol} {cse.xValue2} = {cse.xResultNew}";

            AnswerCorrect = (cse.xResult == cse.xResultNew);

            Change?.Invoke(this, EventArgs.Empty);
        }
        private void DoBack()
        {
            CodeText = $"{cse.xValue1} {cse.Symbol} {cse.xValue2} = {cse.xResultNew}";

            Change?.Invoke(this, EventArgs.Empty);
        }
        //Генератор переодического неверного ответа.
        private double RandomWrong(double xResultNew)
        {
            if (rnd.Next(2) == 1)
                xResultNew += rnd.Next(1, 7) * (rnd.Next(2) == 1 ? 1 : -1);
            return xResultNew;
        }
        //Проверка ответа и счётчик результатов.
        public void DoAnswer(bool v)
        {
            if(v == AnswerCorrect)
                CountCorrect++;
            else
                CountWrong++;
            
            DoContinue();
        }
        //Пропустить и добавить в стек
        public void GoNext()
        {
            var newCse = new Case(cse.xValue1, cse.xValue2, cse.xResult, cse.Symbol, cse.xResultNew);
            cases.Push(newCse);
            DoContinue();
        }
        public void GetBackCase()
        {
            if(cases.Count != 0)
            {
                var backCse = cases.Pop();
                cse = backCse;
            }
            DoBack();
        }
        public bool CheckZeroStack()
        {
            if(cases.Count== 0) return true;
            else return false;
        }

    }
}