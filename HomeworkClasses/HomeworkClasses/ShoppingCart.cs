using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkClasses
{
    internal class ShoppingCart
    {
        private List<Product> items;

        public ShoppingCart()
        {
            items = new List<Product>();
        }
       
        public void AddItem(Product product)
        {
            items.Add(product);
        }

        public void RemoveItem(Product product)
        {
            items.Remove(product);
        }

        public decimal Getsum()
        {
            return items.Sum(item => item.Price);
        }
        public List<Product> GetItems()
        {
            return items;
        }
    }
}
