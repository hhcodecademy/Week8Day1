using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericApp
{
    internal class Mentor:Teacher
    {
        public int Hour { get; set; }

        public Mentor(int hour, int age,
            string name, string surname, string title, decimal salary)
            :base(age, name, surname, title, salary)
        {
        
        }
        public Mentor() { }
    }
}
