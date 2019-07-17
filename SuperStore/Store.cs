using System;
using System.Collections.Generic;
using System.Text;

namespace SuperStore
{
    public class Store
    {
        private Customer _currentCustomer;
        private Inventory _inventory;
        private ShopingCart _shopingCart;
        public Store(Customer currentCustomer)
        {
            _currentCustomer = currentCustomer;
            _inventory = new Inventory();
            _shopingCart = new ShopingCart();
        }

        public void DisplayListOfProducts()
        {
            _inventory.DisplayItem();
        }

        public void DisplayItemsInCart()
        {
            _shopingCart.DisplayItem();
        }

        public void AddProductToCart(int productId, int Quantity)
        {
          
            var product = _inventory.GetProduct(productId, Quantity);
            ApplyDiscount(product);
            _shopingCart.AddItem(product);
        }

        private void ApplyDiscount(Product product)
        {
            if (_currentCustomer.isSeniorCitizen)
            {
                var seniorDiscount = DiscountFactory.GetDiscount(DiscountCategory.SENIOR_CITIZEN_DISCOUNT, product);
                seniorDiscount.DiscountAmount = DiscountConstant.SENIOR_CITIZEN_DISCOUNT_AMOUNT;
                seniorDiscount.SetDiscountOnProduct();
            }

            if (_currentCustomer.CustomerType == CustomerType.CURRENT_EMPLOYEE)
            {
                var employeeDiscount = DiscountFactory.GetDiscount(DiscountCategory.EMPLOYEE_DISCOUNT, product);
                employeeDiscount.DiscountAmount = DiscountConstant.EMPLOYEE_DISCOUNT_AMOUNT;
                employeeDiscount.SetDiscountOnProduct();
            }

            if(product.Category == ProductCategory.Chips)
            {
                var categoryDiscount = DiscountFactory.GetDiscount(DiscountCategory.CHIPS_CATEGORY_DISCOUNT, product);
                categoryDiscount.DiscountAmount = DiscountConstant.CHIPS_DISCOUNT_AMOUNT;
                categoryDiscount.SetDiscountOnProduct();
            }
        }
    }
}
