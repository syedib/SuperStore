using System;
using System.Collections.Generic;
using System.Text;

namespace SuperStore
{
    public class DiscountForSeniorCitizen : ProductDiscount
    {
        private Product _product;
        public DiscountForSeniorCitizen(Product product)
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
