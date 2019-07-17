using System;
using System.Collections.Generic;
using System.Text;

namespace SuperStore
{
    public abstract class ProductManagement
    {
        public Dictionary<int, Product> Items;
        public abstract void AddItem(Product item);
        public abstract void RemoveItemFrom(int ProductId);
        public abstract void DisplayItem();
    }
}
