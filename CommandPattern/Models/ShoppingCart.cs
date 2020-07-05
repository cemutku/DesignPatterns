using System.Collections.Generic;

namespace CommandPattern.Models
{
    public class ShoppingCart
    {
        public ShoppingCart()
        {
            Products = new List<Product>();
        }

        public int Id { get; set; }
        public List<Product> Products { get; set; }
        public int Quantity { get; set; }
    }
}
