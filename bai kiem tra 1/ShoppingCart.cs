using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_kiem_tra_1
{
    internal class ShoppingCart
    {
        public List<Product> CartItems { get; private set; } = new List<Product>();

        public void AddProduct(Product product)
        {
            var existingProduct = CartItems.FirstOrDefault(p => p.Name == product.Name);
            if (existingProduct != null)
            {
                existingProduct.Quantity += product.Quantity;
            }
            else
            {
                CartItems.Add(new Product(product.Name, product.Price, product.Quantity, product.Image));
            }
        }

        public void RemoveProduct(Product product)
        {
            CartItems.Remove(product);
        }

        public decimal CalculateTotal()
        {
            return CartItems.Sum(p => p.Price * p.Quantity);
        }

        public void ClearCart()
        {
            CartItems.Clear();
        }
    }
}
