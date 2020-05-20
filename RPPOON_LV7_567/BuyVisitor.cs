using System;
using System.Collections.Generic;
using System.Text;

namespace RPPOON_LV7_567
{
    class BuyVisitor : IVisitor
    {
        private const double DVDTax = 0.18;
        private const double VHSTax = 0.10;
        private const double BOOKTax = 0.20;
        public double Visit(DVD DVDItem)
        {
            return DVDItem.Price * (1 + DVDTax);
        }
        public double Visit(VHS VHSItem)
        {
            return VHSItem.Price * (1 + VHSTax);
        }

        public double Visit(Book BOOKItem)
        {
            return BOOKItem.Price * (1 + BOOKTax);
        }
    }
}
