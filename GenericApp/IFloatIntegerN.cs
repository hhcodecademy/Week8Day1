﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace GenericApp
{
    internal interface IFloatInteger<T> where T: INumber<int>
    {
    }
}
