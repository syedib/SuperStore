using System;
using Xunit;
using FluentAssertions;
using FluentAssertions.Execution;
namespace SuperStore.Test
{
    public class InventoryTest
    {
        [Fact]
        public void Test_Product_UnderFlow_In_Inventory()
        {
            Inventory sut = new Inventory();

            Action act = () => sut.GetProduct(1, 11);

            act.Should().Throw<ArgumentOutOfRangeException>().WithMessage("Requested Quantity does not exist");
        }

        [Fact]
        public void Test_Product_Does_Not_Exist()
        {
            Inventory sut = new Inventory();

            Action act = () => sut.GetProduct(10, 11);

            act.Should().Throw<ArgumentOutOfRangeException>().WithMessage("Requested product does not exist");
        }
    }
}
