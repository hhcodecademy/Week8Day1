using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GenericApp
{
    internal class DataStoreInt
    {
       
        private int[] ages = new int[10];
  
        public int this[int index]
        {

            get { return ages[index]; }
            set
            {
                if (index > 0 && index < 10)
                {
                    ages[index] = value;
                }
            }
        }
    }
}
