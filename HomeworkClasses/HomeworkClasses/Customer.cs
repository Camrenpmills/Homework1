using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkClasses
{
    internal class Customer
    {
        public string Name { get; set; }
        public ShoppingCart Cart{ get; set; }

        public Customer(string name, ShoppingCart SC)
        {
            Name = name;
            Cart = SC;
        }

        public void AddToCart(Product product)
        {
            Cart.AddItem(product);
        }

        public void RemoveFromCart(Product product)
        {
            Cart.RemoveItem(product);
        }

        public decimal Checkout()
        {
            return Cart.Getsum();
        }
    }

}
