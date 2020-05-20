using System;
using System.Collections.Generic;
using System.Text;

namespace RPPOON_LV7_567
{
    interface IItem
    {
        double Accept(IVisitor visitor);
    }
}
