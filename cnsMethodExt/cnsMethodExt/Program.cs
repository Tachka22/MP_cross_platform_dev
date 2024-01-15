namespace cnsMethodExt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Student student = new("Иванов", "Иван", "Иванович");
            //Console.WriteLine(student.GetFullName()); 
            StudentExt.Hello();
            Console.WriteLine(student.GetFullName());
        }
        
    }
}