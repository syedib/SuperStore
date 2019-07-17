using System;
using System.Collections.Generic;
using System.Text;

namespace SuperStore
{
    public class Inventory : ProductManagement
    {
        public Inventory()
        {
            this.Items = new Dictionary<int, Product>();
            LoadItems();
        }
        public override void AddItem(Product item)
        {
            if (!this.Items.ContainsKey(item.ProductId))
            {
                this.Items.Add(item.ProductId, item);
            }
            else
            {
                this.Items[item.ProductId].Quantity += item.Quantity;
            }
        }

        public override void DisplayItem()
        {
            Console.WriteLine("Product Id | Product Name | Quantity | Unit Price");
            Console.WriteLine("-----------------------------------------------------------");

            foreach (var item in this.Items.Values)
            {
                Console.WriteLine($"{item.ProductId} | {item.Name} | {item.Quantity} | {item.Price} ");
            }
        }

        public override void RemoveItemFrom(int ProductId)
        {
            if (this.Items.ContainsKey(ProductId))
            {
                var product = this.Items[ProductId];
                this.Items.Remove(ProductId);
            }
        }

        public Product GetProduct(int ProductId, int Quantity)
        {
            Product requestedProduct;
            if (this.Items.ContainsKey(ProductId))
            {
                if (this.Items[ProductId].Quantity > Quantity)
                {
                    var productInInventory = this.Items[ProductId];
                    requestedProduct = new Product
                    {
                        Name = productInInventory.Name,
                        Quantity = Quantity,
                        Category = productInInventory.Category,
                        Price = productInInventory.Price,
                        ProductId = productInInventory.ProductId
                    };
                    this.Items[ProductId].Quantity -= Quantity;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Requested Quantity does not exist", new Exception());
                }
            }
            else
            {
                throw new ArgumentOutOfRangeException("Requested product does not exist", new Exception());
            }
            return requestedProduct;
        }

        private void LoadItems()
        {
            this.Items
                .Add(1, new Product() { ProductId = 1, Name = "Apple", Category = ProductCategory.Fruit, Price = 11.0, Quantity = 10 });
            this.Items
                .Add(2, new Product() { ProductId = 2, Name = "Banana", Category = ProductCategory.Fruit, Price = 4.6, Quantity = 18 });
            this.Items
                .Add(3, new Product() { ProductId = 3, Name = "Lays", Category = ProductCategory.Chips, Price = 4.0, Quantity = 15 });
            this.Items
                .Add(4, new Product() { ProductId = 4, Name = "Coke", Category = ProductCategory.DrinksAndBeverages, Price = 8.0, Quantity = 15 });
        }
    }
}
