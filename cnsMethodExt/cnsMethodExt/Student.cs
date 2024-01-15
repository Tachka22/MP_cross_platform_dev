using System.Xml.Linq;

namespace cnsMethodExt
{
    internal class Student
    {
        public Student(string surname, string name, string patronymic)
        {
            Surname = surname;
            Name = name;
            Patronymic = patronymic;
        }

        public string Surname { get; }
        public string Name { get; }
        public string Patronymic { get; }
    }

}