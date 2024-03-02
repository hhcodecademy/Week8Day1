using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace GenericApp
{
    internal class DataStoreGeneric<T> where T :Person, new()
    {
        private T[] values = new T[10];
        
        

        public T this[int index]
        {

            get { return values[index]; }
            set
            {
                if (index > 0 && index < 10)
                {
                    values[index] = value;
                    
                }
            }
        }
    }
}
