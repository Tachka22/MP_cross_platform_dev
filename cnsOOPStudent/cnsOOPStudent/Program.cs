namespace cnsOOPStudent
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.AgeChange += Student_AgeChange;
            student.AgeChange2 += Student_AgeChange2;
            student.Name = "Иван";
            student.Surname = "Иванович";
            student.Age = 10;
            Console.WriteLine(student.GetFullName());
            student.Age = 22;
            Console.WriteLine(student.GetFullName());
           
        }

        private static void Student_AgeChange2(object? sender, int age)
        {
            Console.WriteLine($"Новый возраст, {age}");
        }

        private static void Student_AgeChange(object? sender, EventArgs e)
        {
            if(sender is Student v)
                Console.WriteLine($"Изменился возраст, {v.Age}");

        }
    }
}