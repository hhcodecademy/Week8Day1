﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionApp
{
    internal class InvalidAgeException:Exception
    {
        public InvalidAgeException(string msj)
         : base()
        {
            // Console.WriteLine(msj);
        }
    }
}
