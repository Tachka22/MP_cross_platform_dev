using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cnsOOPStudent
{
    internal class Student
    {
        private int age;

        public event EventHandler AgeChange;

        public delegate void EventHandlerAge(object? sender, int age);
        public event EventHandlerAge AgeChange2;
        public string Name { get; internal set; }
        public string Surname { get; internal set; }
        public int Age
        {
            get 
            { 
                return age;
            }
            internal set
            {
                if (value > 0)
                    age = value;
                AgeChange?.Invoke(this,  EventArgs.Empty);
                AgeChange2?.Invoke(this, Age);
                //if(AgeChange  != null)
                //    AgeChange.Invoke(this, new EventArgs());
            }
        }
       
        public string GetFullName()
        {
            return $"{Name} {Surname} ({Age})";
        }

    }
}
