using System;
using System.Collections.Generic;
using System.Text;

namespace SuperStore
{
    public partial class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public double DiscountAmount { get; set; }
        public ProductCategory Category { get; set; }
    }
}
