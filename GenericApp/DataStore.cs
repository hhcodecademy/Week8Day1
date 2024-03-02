using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericApp
{
    internal class DataStore<T>
    {
        private T _data;

        public T Data {
            get { return _data; } 
            set { _data = value; }        
        }
    }
}
