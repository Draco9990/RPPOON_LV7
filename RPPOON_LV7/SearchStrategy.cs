using System;
using System.Collections.Generic;
using System.Text;

namespace RPPOON_LV7
{
    abstract class SearchStrategy
    {
        public abstract List<int> Search(double[] array, double n);
    }
}
