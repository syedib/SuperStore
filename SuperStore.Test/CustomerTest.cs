using System;
using Xunit;
using FluentAssertions;
using SuperStore;
namespace SuperStore.Test
{
    public class CustomerTest
    {
        [Fact]
        public void Check_Age()
        {
            Customer sut = new Customer();

            sut.FirstName = "Eric";
            sut.LastName = "Evans";
            sut.DateOfBirth = new DateTime(1989, 11, 18);
            sut.Email = "test@test.com";
            sut.PhoneNumber = "9429498982";
            
            sut.age.Should().Be(29);
        }

        [Fact]
        public void Check_Cutomer_Type_should_be_Senior_Citizen()
        {
            Customer sut = new Customer();

            sut.FirstName = "Eric";
            sut.LastName = "Evans";
            sut.DateOfBirth = new DateTime(1956, 11, 18);
            sut.Email = "test@test.com";
            sut.PhoneNumber = "9429498982";

            Assert.True(sut.isSeniorCitizen);
        }

        [Fact]
        public void Check_Cutomer_Type_Should_not_be_Senior_Citizen()
        {
            Customer sut = new Customer();

            sut.FirstName = "Eric";
            sut.LastName = "Evans";
            sut.DateOfBirth = new DateTime(1989, 11, 18);
            sut.Email = "test@test.com";
            sut.PhoneNumber = "9429498982";
            sut.CustomerType = CustomerType.GENERAL_CUSTOMER;

            Assert.False(sut.isSeniorCitizen);
        }
    }
}
