using System;
using Xunit;
using FluentAssertions;
namespace SuperStore.Test
{
    public class DiscountTest
    {
        [Fact]

        public void Test_Employee_Discount()
        {
            ShopingCart cart = new ShopingCart();
            Inventory inventory = new Inventory();

            var product = inventory.GetProduct(1, 2);
            DiscountForEmployee employeeDiscount = new DiscountForEmployee(product);
            employeeDiscount.DiscountAmount = 1.2;
            employeeDiscount.SetDiscountOnProduct();

            Assert.Equal(9.8, product.Price, 1);
        }
    }
}
