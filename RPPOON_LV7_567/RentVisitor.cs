using System;
using System.Collections.Generic;
using System.Text;

namespace RPPOON_LV7_567
{
    class RentVisitor : IVisitor
    {
        private const double Tax = 0.1;
        public double Visit(DVD DVDItem)
        {
            //Zadatak 6
            //if (DVDItem.Type == DVDType.SOFTWARE) return double.NaN;
            if (DVDItem.Type == DVDType.SOFTWARE) return DVDItem.Price;
            else return DVDItem.Price * (1 + Tax);
        }
        public double Visit(VHS VHSItem)
        {
            return VHSItem.Price * (1 + Tax);
        }

        public double Visit(Book BOOKItem)
        {
            return BOOKItem.Price * (1 + Tax);
        }
    }
}
