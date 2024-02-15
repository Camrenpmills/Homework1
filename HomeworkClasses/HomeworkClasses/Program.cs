using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please select from one of the stores");
            Console.WriteLine("1.GooberRus");
            Console.WriteLine("2.Twodollars");

            string userInput = Console.ReadLine();
            int selectedStore; 
            if(int.TryParse(userInput, out selectedStore))
            {
                switch (selectedStore)
                {
                    case 1:
                        Console.WriteLine("You selected GooberRus")
                            ; break;
                    case 2:
                        Console.WriteLine("You selected Twodollar")
                            ; break;        
                }
            }



            //Creating Products 
            Product TV = new Product("P1", "TV", 5.00m);
            Product Computer = new Product("P2", "Computer", 10.00m);
            Product Headphones = new Product("P3", "Headphones", 15.00m);

            GooberRus GB = new GooberRus();
            GB.storecart.AddItem(TV);
            GB.storecart.AddItem(Computer);

            Twodollar TW = new Twodollar();
            TW.storecart.AddItem(Headphones);

            // Customer 
            ShoppingCart ShoppingCartSC = GB.storecart;
            Customer Customer = new Customer("Camren Price",ShoppingCartSC);

            

            //Products in Cart 
             Console.WriteLine("Welcome to the store this is what we have to offer!");
             Console.WriteLine("1. TV $5.00");
             Console.WriteLine("2. Computer $10.00");
             Console.WriteLine("3. Headphones $15.00");
             Console.WriteLine("Select  the numbers of the items you want");
             
             string input = Console.ReadLine();
             string[] selectedProdcuts = input.Split(',');

             foreach (string prodcutNumber in selectedProdcuts)
             {
                 switch (prodcutNumber)
                 {
                     case "1":
                         ShoppingCartSC.AddItem(TV);
                         break;
                     case "2":
                         ShoppingCartSC.AddItem(Computer);
                         break;
                    case "3": 
                         ShoppingCartSC.AddItem(Headphones);
                         break;
                 }
             }
             //Console.WriteLine(TV.Description + " Purchased");
             List<Product> items = ShoppingCartSC.GetItems();
             
             foreach (Product item in items)
             {
                 Console.WriteLine(item.Description + " Purchased");
             }
             Console.ReadLine();

             decimal Total = Customer.Checkout();
             Console.WriteLine("$Total price :" + Customer.Checkout());

            GB.ShowCart();
            GB.goob();
            Console.WriteLine("");
            TW.ShowCart();
            Console.ReadLine();
        }
    }
}
