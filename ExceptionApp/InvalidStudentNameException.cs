using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionApp
{
    internal class InvalidStudentNameException : Exception
    {
        public InvalidStudentNameException(string msj)
            : base()
        {
           // Console.WriteLine(msj);
        }

    }
}
