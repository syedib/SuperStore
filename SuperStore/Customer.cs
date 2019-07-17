using System;
using System.Collections.Generic;
using System.Linq;
using SuperStore.Helper;
namespace SuperStore
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        private int _age = 0;
        private DateTime _dob = DateTime.MinValue;
        public DateTime DateOfBirth
        {
            get { return _dob; }
            set
            {
                this.age = value.CalculateAge();
                _dob = value;
            }
        }
        public int age
        {
            /*
             * Public getter to access Customer age
             * Should not allow client to set cutomer age
             * Private setter to calculate using DateOfBirth Customer age
            */
            get { return _age; }
            private set
            {
                this.isSeniorCitizen = value >= ConstantContext.SENIOR_CITIZEN_MIN_AGE;
                _age = value;
            }
        }

        private bool _isSeniorCitizen = false;
        public bool isSeniorCitizen
        {
            get { return _isSeniorCitizen; }
            private set
            {
                _isSeniorCitizen = value;
            }
        }
        public CustomerType CustomerType{ get; set;}

        private List<Customer> GetListOfCustomers()
        {
            return new List<Customer> {
                new Customer{ CustomerId = 1, FirstName = "Evan", LastName = "Davis",
                    DateOfBirth = new DateTime(1989, 11, 18), Email = "edavis@gmail.com",
                    CustomerType =CustomerType.GENERAL_CUSTOMER, PhoneNumber = "9281313712"},

                new Customer{CustomerId = 2, FirstName = "Selva", LastName = "muthu",
                    DateOfBirth = new DateTime(1957, 06, 18), Email = "smuthu@gmail.com",
                    CustomerType =CustomerType.GENERAL_CUSTOMER, PhoneNumber = "98348364893"},

                new Customer{CustomerId = 3, FirstName = "francis", LastName = "christopher",
                    DateOfBirth = new DateTime(1984, 04, 12), Email = "smuthu@gmail.com",
                    CustomerType =CustomerType.CURRENT_EMPLOYEE, PhoneNumber = "9724562387"}
            };
        }

        public Customer GetCustomerById(int customerId)
        {
            var customer = GetListOfCustomers().FirstOrDefault(cus => cus.CustomerId == customerId);

            if (customer == null) throw new ArgumentNullException("Could not able to found requested customer" , new Exception());

            return customer;
        }
    }
}
