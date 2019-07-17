using System;
using System.Collections.Generic;
using System.Text;

namespace SuperStore
{
    public class ShopingCart : ProductManagement
    {
        public double TotalPrice;
        public ShopingCart()
        {
            this.Items = new Dictionary<int, Product>();
            this.TotalPrice = 0.0;
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

            TotalPrice += item.Price * (double)item.Quantity;
        }

        public override void RemoveItemFrom(int ProductId)
        {
            if (this.Items.ContainsKey(ProductId))
            {
                var product = this.Items[ProductId];
                TotalPrice -= product.Price * (double)product.Quantity;
                this.Items.Remove(ProductId);
            }
        }

        public override void DisplayItem()
        {
            Console.WriteLine(" Product Name | Quantity | Unit Price | Discount | Total Price");
            Console.WriteLine("-----------------------------------------------------------");

            foreach(var item in this.Items.Values)
            {
                Console.WriteLine($"{item.Name} | {item.Quantity} | {item.Price} | {item.DiscountAmount} | {item.Price * (double)item.Quantity}");
            }

            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine($"Total Price: { this.TotalPrice }");
        }
    }
}
