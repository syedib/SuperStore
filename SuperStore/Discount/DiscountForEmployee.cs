using System;
using System.Collections.Generic;
using System.Text;

namespace SuperStore
{
    public class DiscountForEmployee : ProductDiscount
    {
        private Product _product;
        public DiscountForEmployee(Product product)
        {
            _product = product;
        }
        public override void SetDiscountOnProduct()
        {
            _product.DiscountAmount = this.DiscountAmount;
            _product.Price -= this.DiscountAmount ;
        }
    }
}
