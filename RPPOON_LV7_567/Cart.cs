using System;
using System.Collections.Generic;
using System.Text;

namespace RPPOON_LV7_567
{
    class Cart : IItem
    {
        private List<IItem> items = new List<IItem>();

        public double Accept(IVisitor visitor)
        {
            double toReturn = 0;
            foreach(IItem item in items)
            {
                toReturn += item.Accept(visitor);
            }
            return toReturn;
        }

        public void AddItem(IItem item)
        {
            items.Add(item);
        }

        public void RemoveItem(IItem item)
        {
            items.Remove(item);
        }
    }
}
