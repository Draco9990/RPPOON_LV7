using System;
using System.Collections.Generic;
using System.Text;

namespace RPPOON_LV7
{
    class LinearSearch : SearchStrategy
    {
        public override List<int> Search(double[] array, double n)
        {
            List<int> toReturn = new List<int>();
            for(int i = 0; i < array.Length; i++)
            {
                if(array[i] == n)
                {
                    toReturn.Add(i);
                }
            }
            return toReturn;
        }
    }
}
