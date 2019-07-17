using System;
using System.Collections.Generic;
using System.Text;

namespace SuperStore
{
    public class DiscountForChips : ProductDiscount
    {
        private Product _product;
        public DiscountForChips(Product product)
        {
            _product = product;
        }
        public override void SetDiscountOnProduct()
        {
            _product.DiscountAmount = this.DiscountAmount;
            _product.Price -= this.DiscountAmount;
        }
    }
}
