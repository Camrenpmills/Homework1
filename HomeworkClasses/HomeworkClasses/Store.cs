using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkClasses
{
    internal class Store
    {
       public ShoppingCart storecart = new ShoppingCart();

        public void ShowCart()

        {
            foreach (Product item in storecart.GetItems())
            {
                Console.WriteLine(item.Description + " Purchased");
            }
        }



    }


}
