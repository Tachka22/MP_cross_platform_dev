using System.Collections;

namespace cnsGenDice
{
    class Program
    {
        static void Main(string[] args)
        {
            var countOfDice = 8;
            int[] values = new int[] { 1, 2, 3, 4, 5, 6 };
            int faces = 6;
            var t = GenDice(countOfDice, values, faces);
            foreach (var i in t)
            {
                Console.WriteLine(i);
            }
        }
         static  List<int> GenDice(int diceCount, int[] values , int faces = 6)
         {
            if(values.Length == 0) { values= new int[]{1,2,3,4,5,6 }; }
            if (diceCount < 1 || diceCount > 10)
                throw new Exception("Кол-во игральных кубиков должно быть от 1 до 10");
            if (faces == 0)
                throw new Exception("Кол-во граней равно нулю");
            if (faces != values.Length)
                throw new Exception("Кол-во граней не соответсвует кол-ву различных занчений");
                
            List<int> result = new List<int>();

            while(diceCount > 0)
            {
                Random rd = new Random();
                int randomIndex = rd.Next(0, values.Length);
                result.Add(values[randomIndex]);
                diceCount--;
            }
            return result;
         }
    }
}