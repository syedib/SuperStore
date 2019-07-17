using System;
using System.Collections.Generic;
using System.Text;

namespace SuperStore
{
    public abstract class ProductDiscount
    {
        public double DiscountAmount = 0.0;
        public abstract void SetDiscountOnProduct();
    }
}
