using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericApp
{
    internal class Person
    {
        public int Age { get; set; }
        public float Point { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public Person() { }
        public Person(int age)
        {
            this.Age = age;



        }
        public Person(string name, string surname)
        {

            this.Name = name;
            this.Surname = surname;

        }

        public Person(int age, string name, string surname)
        {
            this.Age = age;
            this.Name = name;
            this.Surname = surname;


        }
    }
}
