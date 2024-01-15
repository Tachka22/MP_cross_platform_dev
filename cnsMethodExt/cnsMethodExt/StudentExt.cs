namespace cnsMethodExt
{
     static class StudentExt
    {
        public static void Hello()
        {
            Console.WriteLine("Hello!");
        }
        public static string GetFullName(this Student v)
        {
            return $"{v.Surname} {v.Name} {v.Patronymic}";
        }
    }
}
