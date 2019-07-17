using System;
using Xunit;
using FluentAssertions;

namespace SuperStore.Test
{
    public class CartTest
    {
        [Fact]
        public void Test_Total_Price()
        {
            ShopingCart sut = new ShopingCart();

            var product1 = new Product();

            product1.ProductId = 1;
            product1.Name = "Apple";
            product1.Quantity = 2;
            product1.Price = 12.0;

            var product2 = new Product();

            product2.ProductId = 2;
            product2.Name = "Banana";
            product2.Quantity = 2;
            product2.Price = 5.6;

            sut.AddItem(product1);
            sut.AddItem(product2);

            sut.TotalPrice.Should().Be(35.2);
        }

        [Fact]
        public void Test_Total_Price_After_Removing_Item()
        {
            ShopingCart sut = new ShopingCart();

            var product1 = new Product();

            product1.ProductId = 1;
            product1.Name = "Apple";
            product1.Quantity = 2;
            product1.Price = 12.0;

            var product2 = new Product();

            product2.ProductId = 2;
            product2.Name = "Banana";
            product2.Quantity = 2;
            product2.Price = 5.6;

            sut.AddItem(product1);
            sut.AddItem(product2);

            sut.RemoveItemFrom(2);

            Assert.Equal(24.0, sut.TotalPrice, 1);
        }
    }
}
