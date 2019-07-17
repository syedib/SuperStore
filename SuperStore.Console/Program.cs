using System;
using System.Globalization;
using SuperStore;
namespace SuperStore.ConsoleApp
{
    class Program
    {

        public static void Main(string[] args)
        {

            //Genral customer who got discount for chips
            //DisplayOutputForChipsPurchaes();

            //Senior Citizen customer who purchased 2 items
            //DisplayOutputForSeniorCitizen();

            //Current Employee who purchased 2 items
            DisplayOutputForEmployee();

            Console.ReadKey();

        }

        static void DisplayOutputForChipsPurchaes()
        {
            var currentCustomer = (new Customer()).GetCustomerById(1);

            /* Current Customer
             * CustomerId = 1, FirstName = "Evan", LastName = "Davis",
               DateOfBirth = new DateTime(1989, 11, 18), Email = "edavis@gmail.com",
               CustomerType =CustomerType.GENERAL_CUSTOMER, PhoneNumber = "9281313712" */

            // Purchasing Chips

            var store = new Store(currentCustomer);

            store.DisplayListOfProducts();

            /* Product Id | Product Name | Quantity | Unit Price
                -----------------------------------------------------------
                1         | Apple        | 10       | 11
                2         | Banana       | 18       | 4.6
                3         | Lays         | 15       | 4
                4         | Coke         | 15       | 8
             */

            store.AddProductToCart(3, 2);
            store.AddProductToCart(1, 2);

            store.DisplayItemsInCart();

            //Here Current Customer general cutomer who Added 2 items in cart. discount applied for chips alone
            /*
              Product Name | Quantity | Unit Price | Discount | Total Price
            -----------------------------------------------------------
            Lays           | 2        | 3.7        | 0.3      | 7.4
            Apple          | 2        | 11         | 0        | 22
            -----------------------------------------------------------
            Total Price: 29.4
             */

            store.DisplayListOfProducts();

            /* Remaining items in inventory after added to cart 
            Product Id | Product Name | Quantity | Unit Price
            -----------------------------------------------------------
            1          | Apple        | 8        | 11
            2          | Banana       | 18       | 4.6
            3          | Lays         | 13       | 4
            4          | Coke         | 15       | 8 

             */
        }

        static void DisplayOutputForSeniorCitizen()
        {
            var currentCustomer = (new Customer()).GetCustomerById(2);

            /* Current Customer
             * CustomerId = 2, FirstName = "Selva", LastName = "muthu",
               DateOfBirth = new DateTime(1957, 06, 18), Email = "smuthu@gmail.com",
               CustomerType =CustomerType.GENERAL_CUSTOMER, PhoneNumber = "98348364893" */

            // Purchasing Chips

            var store = new Store(currentCustomer);

            store.DisplayListOfProducts();

            /* Product Id | Product Name | Quantity | Unit Price
                -----------------------------------------------------------
                1         | Apple        | 10       | 11
                2         | Banana       | 18       | 4.6
                3         | Lays         | 15       | 4
                4         | Coke         | 15       | 8
             */

            store.AddProductToCart(1, 2);
            store.AddProductToCart(2, 2);

            store.DisplayItemsInCart();

            //Here Current Customer general cutomer who Added 2 items in cart. discount applied for chips alone
            /*
                Product Name | Quantity | Unit Price | Discount | Total Price
                -----------------------------------------------------------
                Apple        | 2        | 10.6       | 0.4      | 21.2
                Banana       | 3        | 4.2        | 0.4      | 12.6
                -----------------------------------------------------------
                Total Price: 33.8
             */

            store.DisplayListOfProducts();

            /* Remaining items in inventory after added to cart 
            Product Id | Product Name | Quantity | Unit Price
            -----------------------------------------------------------
            1          | Apple        | 8        | 11
            2          | Banana       | 18       | 4.6
            3          | Lays         | 13       | 4
            4          | Coke         | 12       | 8 

             */
        }

        static void DisplayOutputForEmployee()
        {
            var currentCustomer = (new Customer()).GetCustomerById(3);

            /* Current Customer
             * CustomerId = 3, FirstName = "francis", LastName = "christopher",
               DateOfBirth = new DateTime(1984, 04, 12), Email = "smuthu@gmail.com",
               CustomerType =CustomerType.CURRENT_EMPLOYEE, PhoneNumber = "9724562387" */

            // Purchasing Chips

            var store = new Store(currentCustomer);

            store.DisplayListOfProducts();

            /* Product Id | Product Name | Quantity | Unit Price
                -----------------------------------------------------------
                1         | Apple        | 10       | 11
                2         | Banana       | 18       | 4.6
                3         | Lays         | 15       | 4
                4         | Coke         | 15       | 8
             */

            store.AddProductToCart(1, 2);
            store.AddProductToCart(2, 3);

            store.DisplayItemsInCart();

            //Here Current Customer general cutomer who Added 2 items in cart. discount applied for chips alone
            /*
               Product Name | Quantity | Unit Price | Discount | Total Price
                -----------------------------------------------------------
                Apple       | 2        | 10.5       | 0.5      | 21
                Banana      | 2        | 4.1        | 0.5      | 8.2
                -----------------------------------------------------------
                Total Price: 29.2
             */

            store.DisplayListOfProducts();

            /* Remaining items in inventory after added to cart 
            Product Id | Product Name | Quantity | Unit Price
            -----------------------------------------------------------
            1          | Apple        | 8        | 11
            2          | Banana       | 16       | 4.6
            3          | Lays         | 13       | 4
            4          | Coke         | 15       | 8 

             */
        }
    }
}
