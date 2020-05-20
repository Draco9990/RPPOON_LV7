using System;
using System.Collections.Generic;
using System.Text;

namespace RPPOON_LV7_567
{
    interface IVisitor
    {
        double Visit(DVD DVDItem);
        double Visit(VHS VHSItem);
        double Visit(Book BOOKItem);
    }
}
