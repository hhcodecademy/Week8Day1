using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericApp
{
    internal class DataStoreCommon
    {
       
        private int[] ages = new int[10];
        private float[] points = new float[10];

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

    

        //public float this[int index]
        //{

        //    get { return points[index]; }
        //    set
        //    {
        //        if (index > 0 && index < 10)
        //        {
        //            points[index] = value;
        //        }
        //    }
        //}
    }
}
