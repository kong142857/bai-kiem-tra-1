using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace bai_kiem_tra_1
{
    internal class Product
    {
        public Image Image { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public Product(string name, decimal price, int quantity, Image image = null)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
            Image = image;
        }
    }
}
