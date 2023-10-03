using System.Text;
using System.Text.RegularExpressions;

namespace cnsGenPassword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GeneratePasswords(3,8,true, true, true, true).ForEach(i => Console.WriteLine(i + " "));
            Console.WriteLine();
            GeneratePasswords(4,8,true, false, true, true).ForEach(i => Console.WriteLine(i + " "));
            Console.WriteLine();
            GeneratePasswords(2,8,true, true, false, true).ForEach(i => Console.WriteLine(i + " "));
            Console.WriteLine();
            GeneratePasswords(5,8,true, true, true, false).ForEach(i => Console.WriteLine(i + " "));   
            Console.WriteLine();
            //GeneratePasswords(5,8,false, false, false, false).ForEach(i => Console.Write(i + " ")); // получим Exception т к все параметры false
            Console.WriteLine();
            GeneratePasswords(5, 8, true).ForEach(i => Console.Write(i + " "));
        }

        private static List<string> GeneratePasswords(int countPass, int charCount,bool number = true, bool lower = true, bool upper = true, bool specialCharacters = true)
        {
            if (countPass < 0) throw new Exception("The number of requested passwords is zero");
            if (charCount < 0) throw new Exception("The number of requested characters in the password is zero");
            if (charCount > int.MaxValue / 8) throw new Exception("The password length is too long");

            const string string1 = "1234567890";
            const string string2 = "abcdefghijklmnopqrstuvwxyz";
            const string string3 = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string string4 = "!#$%&’()*+-./:;<=>?@[]^_`}{|~";
            string str = "";

            if (number) str += string1;
            if (lower) str += string2;
            if (upper) str += string3;
            if (specialCharacters) str += string4;
            else if (!number && !lower&& !upper && !specialCharacters) throw new Exception("Symbols are not assigned for generation");
            
            List<string> result = new();
            while (countPass > 0)
            {
                StringBuilder sb = new();
                Random random= new Random();
                for (int i = 0; i < charCount; i++)
                {
                    sb.Append(str[random.Next(str.Length)]);
                }
                result.Add(sb.ToString());
                countPass--;
            }
            return result;
        }
    }
}