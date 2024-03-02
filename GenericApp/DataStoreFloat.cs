using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericApp
{
    internal class DataStoreFloat
    {
        private float[] points = new float[10];

        public float this[int index]
        {

            get { return points[index]; }
            set
            {
                if (index > 0 && index < 10)
                {
                    points[index] = value;
                }
            }
        }
    }
}
