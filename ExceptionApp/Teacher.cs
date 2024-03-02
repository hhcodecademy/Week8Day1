using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionApp
{
    internal class Teacher : Person
    {
        public decimal Salary { get; set; }
        public string Title { get; set; }

        public Teacher(int age, string name, string surname, string title, decimal salary)
        : base(age, name, surname)
        {

            this.Salary = salary;
            this.Title = title;

        }
        public override string ToString()
        {
            string fullDesc = $"Name: {this.Name} Surname: {this.Surname} Titlt: {this.Title}  Salary: {this.Salary}  Age: {this.Age} ";
            return fullDesc;
        }

    }
}
